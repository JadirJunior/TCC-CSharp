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
using System.Windows.Shapes;

namespace PrjTreino
{
    /// <summary>
    /// Lógica interna para CadastreSe.xaml
    /// </summary>
    public partial class CadastreSe : Window
    {
        loginControler login = new loginControler();
        public CadastreSe()
        {
            InitializeComponent();
        }

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void BtnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            if (txtUsuario.Text.Equals("") || txtSenha.Password.Equals("") || txtConfSenha.Password.Equals(""))
                caixaMensagem("Por favor, não deixe nenhum espaço em branco");


            else if (!txtConfSenha.Password.Equals(txtSenha.Password))
            {
                caixaMensagem("Senhas não conferem!");
            }
            else
            {
                bool resultado = login.cadastrarFuncionario(new Funcionario(txtUsuario.Text, txtSenha.Password));
                if (resultado)
                    caixaMensagem("Usuário cadastrado com sucesso!");

                else if (resultado == false && login.Erro == true)
                {
                    caixaMensagem("Ocorreu algum erro, tente novamente");
                }
                else
                {
                    caixaMensagem("Usuário já existe!");
                }
            }
           
            
        }

        public async void caixaMensagem(String message)
        {
            NotificationInformation msg = new NotificationInformation();
            msg.Message = message;
            await DialogHost.Show(msg, "DialogNormal");
            txtUsuario.Text = "";
            txtSenha.Password = "";
            txtConfSenha.Password = "";
        }
    }
}
