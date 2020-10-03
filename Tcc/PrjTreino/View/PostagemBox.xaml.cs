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
using System.Windows.Shapes;

namespace PrjTreino.View
{
    /// <summary>
    /// Lógica interna para PostagemBox.xaml
    /// </summary>
    public partial class PostagemBox : Window
    {
        public PostagemBox()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            new PostagemController().addPostagem(new DAL.models.Postagem()
            {
                AuthorId = StaticKeys.id_func,
                AuthorName = StaticKeys.Usuario,
                Content = txtPostagem.Text
            });

            txtPostagem.Text = "";

            Mural.renderPosts();
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
