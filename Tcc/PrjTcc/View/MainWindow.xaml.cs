using MaterialDesignThemes.Wpf;
using PrjTreino.Controles;
using PrjTreino.DAL.models;
using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PrjTreino
{

    public partial class MainWindow : Window
    {
        loginControler login = new loginControler();
        public MainWindow()
        {
            InitializeComponent();
            if (login.ManterConectado() && WindowMain.loggout == false)
            {
                MainWindow w = this;
                WindowMain window = new WindowMain();
                w.Close();
                window.Show();
            }
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {   
            //DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txtUsuario.Text.Equals("") || txtSenha.Password.Equals(""))
            {
                MessageError("Por favor, não deixe nenhum espaço em branco!");
                return;
            }
            String message = login.iniciarSessao(new Funcionario(txtUsuario.Text, txtSenha.Password));

            if (login.Erro)
            {
                MessageError(message);
                login.Erro = false;
            }
                

            else if (login.resultado)
            {
                StaticKeys.Usuario = txtUsuario.Text;
                StaticKeys.Senha = txtSenha.Password;
                StaticKeys.Manter_conectado = manter_conectado.IsChecked == true ? true : false;
                BemVindo();
            }

            else
            {
                MessageError(message);
                login.Erro = false;
            }
        }

        private void Run_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtUsuario.Text = "";
            txtSenha.Password = "";
            CadastreSe cad = new CadastreSe();
            cad.ShowDialog();
        }

        public async void MessageError(String Message)
        {
            NotificationInformation msg = new NotificationInformation();
            msg.Message = Message;
            msg.Icon = "Exclamation";
            await DialogHost.Show(msg, "RootDialog");
        }

        public async void BemVindo()
        {
            NotificationInformation msg = new NotificationInformation();
            msg.Message = "Bem vindo!";
            msg.Icon = "Login";

            await DialogHost.Show(msg, "RootDialog");
            MainWindow w = this;
            WindowMain window = new WindowMain();
            w.Close();
            window.Show();
        }

        private void Container_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                this.DragMove();
        }
    }
}
