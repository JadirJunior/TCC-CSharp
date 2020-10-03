using PrjTreino.Controles;
using PrjTreino.DAL.models;
using PrjTreino.userControls;
using PrjTreino.userControls.Classes;
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
    /// Interação lógica para Mural.xam
    /// </summary>
    public partial class Mural : UserControl
    {
        private List<Compromisso> reunioes;
        private static Mural mural;

        public Mural()
        {
            InitializeComponent();
            mural = this;
            renderPosts();
        }

        private static Mural getInstance()
        {
            return mural;
        }

        public static void renderNotas()
        {
            Mural instance = getInstance();
            instance.PrincipalContent.Children.Clear();

            Thickness t = new Thickness();

            t.Top = 10;
            t.Bottom = 10;

            instance.PrincipalContent.Children.Add(new NovaNota() {
                Height = 30,
                Width = 300,
                Margin = t,
                FontSize = 12
            });

            if (StaticKeys.Notas == null) return;

            if (StaticKeys.Notas.Count == 0) return;

            

            foreach (Nota nota in StaticKeys.Notas)
            {
                instance.PrincipalContent.Children.Add(new NotaUI(nota.Content) {
                    Height = 30,
                    Width = 300,
                    Margin = t,
                    FontSize = 12
                });
            }
        }

        public static void renderPosts()
        {
            Mural instance = getInstance();
            instance.PrincipalContent.Children.Clear();

            Thickness t = new Thickness();

            t.Top = 10;
            t.Bottom = 10;

            instance.PrincipalContent.Children.Add(new NovaPostagemCard()
            {
                Height = 30,
                Width = 300,
                Margin = t,
                FontSize = 12
            });

            if (StaticKeys.Postagens == null) return;

            if (StaticKeys.Postagens.Count == 0) return;



            foreach (Postagem post in StaticKeys.Postagens)
            {
                instance.PrincipalContent.Children.Add(new PostagemUI(post)
                {
                    Height = 100,
                    Width = 300,
                    Margin = t
                });
            }
        }

        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            PrincipalContent.Children.Clear();
            reunioes = new ReunioesController().getReuniao();

            if (reunioes.Count == 0) return;

            foreach (Compromisso reuniao in reunioes)
            {

                Thickness t = new Thickness();

                t.Top = 10;
                t.Bottom = 10;

                PrincipalContent.Children.Add(new ItemListMeets(reuniao.Nome)
                {
                    Margin = t,
                    Width = 300,
                    Height = 30
                });

            }



        }

        private void Notas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            PrincipalContent.Children.Clear();
            renderNotas();

        }

        private void Postagens_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            PrincipalContent.Children.Clear();
            Thickness t = new Thickness();
            t.Top = 10;
            t.Bottom = 10;

            PrincipalContent.Children.Add(new NovaPostagemCard() {
                Height = 30,
                Width = 300,
                Margin = t,
                FontSize = 12
            });

            List<Postagem> postagens = StaticKeys.Postagens;

            foreach (Postagem postagem in postagens)
            {
                PrincipalContent.Children.Add(new PostagemUI(postagem) {
                    Height = 100,
                    Width = 300,
                    Margin = t
                });
            }

        }
    }
}
