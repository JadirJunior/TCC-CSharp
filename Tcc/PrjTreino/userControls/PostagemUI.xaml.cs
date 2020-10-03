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

namespace PrjTreino.userControls
{
    /// <summary>
    /// Interação lógica para PostagemUI.xam
    /// </summary>
    public partial class PostagemUI : UserControl
    {
        public int AuthorId;
        public PostagemUI(Postagem postagem)
        {
            InitializeComponent();

            AuthorName.Text = postagem.AuthorName;
            AuthorId = postagem.AuthorId;
            content.Text = postagem.Content;

            if (AuthorId != StaticKeys.id_func) btnExcluir.Visibility = Visibility.Hidden; 

        }

        private void BtnExcluir_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var posts = StaticKeys.Postagens.Where(postagem => postagem.Content == content.Text);
            if (posts.Count() == 0) return;

            Postagem post = posts.First();

            new PostagemController().deletePostagem(post);

            Mural.renderPosts();
        }
    }
}
