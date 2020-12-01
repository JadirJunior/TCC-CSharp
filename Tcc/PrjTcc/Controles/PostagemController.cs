using PrjTreino.DAL;
using PrjTreino.DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PrjTreino.Controles
{
    public class PostagemController
    {


        public List<Postagem> getPostagens()
        {
           return new PostagemCommands().getPostagens();
        }

        public void addPostagem(Postagem postagem)
        {
           bool res = new PostagemCommands().addPostagem(postagem);

            if (res) return;

            MessageBox.Show("Ocorreu um Erro!");
        }

        public void deletePostagem(Postagem postagem)
        {
            bool res = new PostagemCommands().deletePostagem(postagem);

            if (res) return;

            MessageBox.Show("Ocorreu um Erro!");
        }
    }
}
