using MaterialDesignThemes.Wpf;
using PrjTreino.Controles;
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
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        loginControler login = new loginControler();
        public MainWindow()
        {
            InitializeComponent();
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
            String message = login.iniciarSessao(txtUsuario.Text, txtSenha.Password);

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
            this.Hide();
            WindowMain window = new WindowMain();
            window.Show();
        }
    }
}
