using PrjTreino.Controles;
using PrjTreino.userControls;
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
    /// <summary>
    /// Lógica interna para WindowMain.xaml
    /// </summary>
    public partial class WindowMain : Window
    {
        public trocaProp troca { get; set; }
        public WindowMain()
        {
            InitializeComponent();
            troca = new trocaProp() { Usuario = StaticKeys.Usuario };
            this.DataContext = troca;
            stackPanelPrincipal.Children.Add(new Mural());
            if (StaticKeys.caminhoImagem == null)
            {
                Uri uri = new Uri("/assets/imageDefault.png", UriKind.Relative);
                imageButton.Source = new BitmapImage(uri);
            } else
            {
                imageButton.Source = StaticKeys.caminhoImagem;
            }
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
            stackPanelPrincipal.Children.Add(new Mural());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            troca = new trocaProp() { Usuario = StaticKeys.Usuario };
            this.DataContext = troca;
            if (StaticKeys.caminhoImagem != null)
                imageButton.Source = StaticKeys.caminhoImagem;
            stackPanelPrincipal.Children.Clear();
            stackPanelPrincipal.Children.Add(new Status());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            troca = new trocaProp() { Usuario = StaticKeys.Usuario };
            this.DataContext = troca;
            if (StaticKeys.caminhoImagem != null)
                imageButton.Source = StaticKeys.caminhoImagem;
            stackPanelPrincipal.Children.Clear();
            stackPanelPrincipal.Children.Add(new Calendario());
        }

        private void BtnUser_Click(object sender, RoutedEventArgs e)
        {
            troca = new trocaProp() { Usuario = StaticKeys.Usuario };
            this.DataContext = troca;
            if (StaticKeys.caminhoImagem != null)
                imageButton.Source = StaticKeys.caminhoImagem;
            stackPanelPrincipal.Children.Clear();
            stackPanelPrincipal.Children.Add(new editUser());
        }
    }
}