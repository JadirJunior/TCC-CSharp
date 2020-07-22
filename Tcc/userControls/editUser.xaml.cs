using MaterialDesignThemes.Wpf;
using Microsoft.Win32;
using PrjTreino.Controles;
using PrjTreino.DAL;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace PrjTreino.userControls
{
    /// <summary>
    /// Interação lógica para editUser.xam
    /// </summary>
    public partial class editUser : UserControl
    {
        public String caminhoImagem = "";
        loginControler login = new loginControler();
        public editUser()
        {
            InitializeComponent();
            txtUsuario.Text = StaticKeys.Usuario;
            txtSenha.Text = StaticKeys.Senha;
            if (StaticKeys.caminhoImagem != null) foto_func.Source = StaticKeys.caminhoImagem;
        }

        private void OpenDialog_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" + "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
        "Portable Network Graphic (*.png)|*.png";
            if (open.ShowDialog() == true)
            {
                foto_func.Source = new BitmapImage(new Uri(open.FileName));
                caminhoImagem = open.FileName;
            }
        }

        private void BtnAtualizar_Click(object sender, RoutedEventArgs e)
        {
            if (txtUsuario.Text.Equals("") || txtSenha.Text.Equals(""))
            {
                caixaDialogo("Por favor, não deixe nenhum texto em branco", "Exclamation");
                return;
            }
            bool resultado = caminhoImagem == "" ? 
                login.atualizarFuncionario(txtUsuario.Text, txtSenha.Text) : 
                login.atualizarFuncionarioComImagem(txtUsuario.Text, txtSenha.Text, caminhoImagem);
            if (login.Erro)
            {
                caixaDialogo("Ocorreu algum erro, tente novamente", "Error");
            } else if (resultado == false && login.Erro == false)
            {
                caixaDialogo("Já existe um usuário com esse nome!", "Exclamation");
            } else if (resultado)
            {
                caixaDialogo("Usuário atualizado com sucesso!", "Information");
            }
        }


        private async void caixaDialogo(String Message, String Icon)
        {
            NotificationInformation box = new NotificationInformation();
            box.Message = Message;
            box.Icon = Icon;
            await DialogHost.Show(box, "dialogUpdate");
        }
    }
}
