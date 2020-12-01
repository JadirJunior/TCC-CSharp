using PrjTreino.Controles;
using PrjTreino.View;
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

namespace PrjTreino.userControls
{
    /// <summary>
    /// Interação lógica para NovaPostagemCard.xam
    /// </summary>
    public partial class NovaPostagemCard : UserControl
    {
        public NovaPostagemCard()
        {
            InitializeComponent();
        }

        private void BtnNovoPost_Click(object sender, RoutedEventArgs e)
        {
            String text = new TextRange(txtPost.Document.ContentStart, txtPost.Document.ContentEnd).Text;
            if (text.Trim() == "") return;
            new PostagemController().addPostagem(new DAL.models.Postagem()
            {
                AuthorId = StaticKeys.id_func,
                AuthorName = StaticKeys.Usuario,
                Content = text
            });
            txtPost.Document.Blocks.Clear();
            Mural.renderPosts();
        }
    }
}
