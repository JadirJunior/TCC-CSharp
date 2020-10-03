using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace PrjTreino.DAL.models
{
    public class Funcionario
    {


        public Funcionario(String nome, String senha, int id, BitmapImage img)
        {
            this.nome = nome;
            this.senha = senha;
            this.id = id;
            this.foto = img;
        }

        public Funcionario(String nome, String senha, int id)
        {
            this.nome = nome;
            this.senha = senha;
            this.id = id;
        }

        public Funcionario(String nome, String senha)
        {
            this.nome = nome;
            this.senha = senha;
        }

        private String nome;
        public String Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }

        private String senha;
        public String Senha
        {
            get
            {
                return senha;
            }
            set
            {
                senha = value;
            }
        }

        private int id;
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        private BitmapImage foto;
        public BitmapImage Foto
        {
            get
            {
                return foto;
            }

            set
            {
                foto = value;
            }
        }

    }
}
