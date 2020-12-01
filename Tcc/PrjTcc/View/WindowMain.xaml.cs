using PrjTreino.Controles;
using PrjTreino.DAL;
using PrjTreino.DAL.models;
using PrjTreino.userControls;
using PrjTreino.Utils;
using PrjTreino.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PrjTreino
{
    public partial class WindowMain : Window
    {
        public trocaProp troca { get; set; }
        public static bool loggout = false;
        public static WindowMain window;


        private void setDimensions(double width, int height, Thickness margin)
        {
            stackPanelPrincipal.MaxWidth = width + 300;
            stackPanelPrincipal.Margin = margin;
            stackPanelPrincipal.Width = width;
            stackPanelPrincipal.Height = height;
        }


        public WindowMain()
        {
            window = this;
            InitializeComponent();
            loggout = false;
            stackPanelPrincipal.MaxWidth = 1000;
            troca = new trocaProp() { Usuario = StaticKeys.Usuario};
            this.DataContext = troca;
            StaticKeys.Postagens = new PostagemCommands().getPostagens();
            stackPanelPrincipal.Children.Add(new Mural());
            if (StaticKeys.caminhoImagem == null)
            {
                Uri uri = new Uri("/assets/imageDefault.png", UriKind.Relative);
                imageButton.Source = new BitmapImage(uri);
                StaticKeys.caminhoImagem = new BitmapImage(uri);
            } else
            {
                imageButton.Source = StaticKeys.caminhoImagem;
            }

            StaticKeys.Notas = new List<Nota>();
            StaticKeys.Notas = new NotaController().getNotas();

            calendarioControler calendarioControler = new calendarioControler();

            if (calendarioControler.selecionarCalendario(StaticKeys.id_func))
                return;

            else
                MessageBox.Show("Ocorreu algum erro ao pegar as datas de compromissos...", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            troca = new trocaProp() { Usuario = StaticKeys.Usuario };
            this.DataContext = troca;
            if (StaticKeys.caminhoImagem != null)
                imageButton.Source = StaticKeys.caminhoImagem;

            stackPanelPrincipal.Children.Clear();
            setDimensions(800, 500, new Thickness()
            {
                Left = 0,
                Top = -10,
                Right = 50,
                Bottom = 0,
            });
            stackPanelPrincipal.Children.Add(new Mural());
        }


        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            troca = new trocaProp() { Usuario = StaticKeys.Usuario };
            this.DataContext = troca;
            if (StaticKeys.caminhoImagem != null)
                imageButton.Source = StaticKeys.caminhoImagem;
            stackPanelPrincipal.Children.Clear();
            setDimensions(800, 500, new Thickness()
            {
                Left = 0,
                Top = -10,
                Right = 50,
                Bottom = 0,
            });
            stackPanelPrincipal.Children.Add(new Calendario());
        }

        private void BtnUser_Click(object sender, RoutedEventArgs e)
        {
            troca = new trocaProp() { Usuario = StaticKeys.Usuario };
            this.DataContext = troca;
            if (StaticKeys.caminhoImagem != null)
                imageButton.Source = StaticKeys.caminhoImagem;
            stackPanelPrincipal.Children.Clear();
            setDimensions(800, 500, new Thickness() {
                Left = 0,
                Top = -10,
                Right = 50,
                Bottom = 0,
            });
            stackPanelPrincipal.Children.Add(new editUser());
        }

        private void BtnChat_Click(object sender, RoutedEventArgs e)
        {
            stackPanelPrincipal.Children.Clear();
            
            setDimensions(containerPrincipal.Width, 650, new Thickness() {
                Left = 113,    
                Top = 88,
                Right = 0,
                Bottom = 0
            });

            stackPanelPrincipal.Children.Add(new ChatControl() {
                Width = containerPrincipal.Width,
                Height = 650
            });
            if (Socket.client.ReadyState == EngineIOSharp.Common.Enum.EngineIOReadyState.CLOSED)
            {
                new Socket();
            }
        }

        public void changeData()
        {
            nome_func.Text = StaticKeys.Usuario;
            if (StaticKeys.caminhoImagem == null)
            {
                Uri uri = new Uri("/assets/imageDefault.png", UriKind.Relative);
                imageButton.Source = new BitmapImage(uri);
                StaticKeys.caminhoImagem = new BitmapImage(uri);
            }
            else
            {
                imageButton.Source = StaticKeys.caminhoImagem;
            }
        }

        private void BtnLogout_Click(object sender, RoutedEventArgs e)
        {
            WindowMain window = this;
            loggout = true;
            
            window.Close();
        }

        private void Container_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                this.DragMove();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (loggout)
            {
                new loginControler().deleteConects(Environment.MachineName);
                StaticKeys.resetKeys();
                MainWindow login = new MainWindow();
                login.Show();
                return;
            }

            if (StaticKeys.Manter_conectado)
            {
                new loginControler().insertConnection();
            }
        }
    }
}