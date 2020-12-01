using PrjTreino.DAL.models;
using PrjTreino.Utils;
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

namespace PrjTreino.userControls.Chat
{
    /// <summary>
    /// Interação lógica para CardChat.xam
    /// </summary>
    public partial class CardChat : UserControl
    {
        public CardChat(String username, BitmapImage image)
        {
            InitializeComponent();
            txtUsername.Text = username;
            imageButton.Source = image;
        }

        public CardChat()
        {
            InitializeComponent();
        }

        private void Content_MouseDown(object sender, MouseButtonEventArgs e)
        {
            content.Background = Brushes.LightGray;
            Funcionario func = StaticKeys.funcionarios.Where(f => f.Nome == txtUsername.Text).First();
            StaticKeys.idFuncChat = func.Id;
            ChatControl.control.selectChat(func.Nome, func.Foto);
        }

        private void Content_MouseLeave(object sender, MouseEventArgs e)
        {
            content.Background = Brushes.White;
        }

        private void Content_MouseEnter(object sender, MouseEventArgs e)
        {
            content.Background = Brushes.LightGray;
        }
    }
}
