using PrjTreino.DAL.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace PrjTreino.DAL
{
    public class LoginComands
    {
        Conexao con;
        SqlCommand cmd;
        SqlDataReader drb;
        public bool Erro = false;
        public String  messageError = "";
        public BitmapImage imagem;
        public int id_func;

        public Controles.loginControler loginControler
        {
            get => default;
            set
            {
            }
        }

        public bool CadastrarFuncionario(Funcionario func)
        {
            /* if (caminhoImagem == "")
             {

             }
             byte[] imagem_byte = null;
             FileStream fs = new FileStream(caminhoImagem, FileMode.Open, FileAccess.Read);
             BinaryReader br = new BinaryReader(fs);
             imagem_byte = br.ReadBytes((int)fs.Length);*/
            bool existe = verificarUsuario(func.Nome) ? true : false;
            if (existe)
            {
                con.Desconectar();
                return false;
            }

            cmd.CommandText = "insert into funcionarios  (nome_func, senha_func) values (@n, @s)";
            cmd.Parameters.AddWithValue("@n", func.Nome);
            cmd.Parameters.AddWithValue("@s", func.Senha);
            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
                con.Desconectar();
                return true;
            }
            catch (SqlException)
            {
                Erro = true;
                return false;
                throw;
            }
        }


        public bool verificarUsuario(String usuario)
        {
            bool exist = false;
            con = new Conexao();
            cmd = new SqlCommand();
            cmd.CommandText = "select * from funcionarios where nome_func = @f";
            cmd.Parameters.AddWithValue("@f", usuario);
            try
            {
                cmd.Connection = con.Conectar();
                drb = cmd.ExecuteReader();
                if (drb.HasRows)
                    exist = true;
                drb.Close();

                return exist;
            }
            catch (Exception)
            {
                Erro = true;
                return true;
                throw;
            }
        }


        public List<String> verificarUsuarios()
        {
            List<String> User = new List<string>();
            con = new Conexao();
            cmd = new SqlCommand();
            cmd.CommandText = "select * from funcionarios where nome_func != @f";
            cmd.Parameters.AddWithValue("@f", StaticKeys.Usuario);
            try
            {
                cmd.Connection = con.Conectar();
                drb = cmd.ExecuteReader();
                while (drb.Read())
                {
                    User.Add(drb["nome_func"].ToString());
                }
                drb.Close();
            }
            catch (Exception)
            {
                Erro = true;
                return null;
                throw;
            }
            return User;
        }


        public bool iniciarSessao(Funcionario func)
        {
            bool acesso = false;
            con = new Conexao();
            cmd = new SqlCommand();
            cmd.CommandText = "select * from funcionarios where nome_func = @n and senha_func = @s";
            cmd.Parameters.AddWithValue("@n", func.Nome);
            cmd.Parameters.AddWithValue("@s", func.Senha);
            try
            {
                cmd.Connection = con.Conectar();
                drb = cmd.ExecuteReader();
                while (drb.Read())
                {
                    if (drb.HasRows)
                    {
                        acesso = true;
                    }
                    if (drb["foto_func"] == System.DBNull.Value || drb["foto_func"].ToString() == "")
                    {
                        imagem = null;

                    }
                    else
                    {
                        BitmapImage image = new BitmapImage();
                        byte[] ima = null;
                        ima = (byte[])drb["foto_func"];
                        MemoryStream ms = new MemoryStream(ima);
                        image.BeginInit();
                        image.StreamSource = ms;
                        image.EndInit();
                        StaticKeys.caminhoImagem = image;
                    }
                    StaticKeys.id_func =  int.Parse(drb["id_func"].ToString());
                }
                drb.Close();
                return acesso;

            }
            catch (SqlException er)
            {
                MessageBox.Show(er.ToString());
                Erro = true;
                return false;
                throw;
            }
        }

        public bool atualizarUsuario(Funcionario func)
        {
            List<String> users = new List<string>();
            users = verificarUsuarios();
            if (Erro)
                return false;
            if (users.Contains(func.Nome))
                return false;

            cmd.CommandText = "update funcionarios set nome_func = @nomeNovo, senha_func = @senha where nome_func = @nome";
            cmd.Parameters.AddWithValue("@nomeNovo", func.Nome);
            cmd.Parameters.AddWithValue("@senha", func.Senha);
            cmd.Parameters.AddWithValue("@nome", StaticKeys.Usuario);

            try
            {
                cmd.ExecuteNonQuery();
                con.Desconectar();
                StaticKeys.Usuario = func.Nome;
                StaticKeys.Senha = func.Senha;
                Erro = false;
                return true;
            }
            catch (SqlException)
            {
                Erro = true;
                return false;
                throw;
            }
        }

        public bool atualizarUsuarioComImagem(Funcionario func, String caminho)
        {
            List<String> users = new List<string>();
            users = verificarUsuarios();
            if (Erro)
                return false;
            if (users.Contains(func.Nome))
                return false;
            byte[] imagem_byte = null;
            FileStream fs = new FileStream(caminho, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            imagem_byte = br.ReadBytes((int)fs.Length);
            cmd.CommandText = "update funcionarios set nome_func = @nomeNovo, senha_func = @senha, foto_func = @foto where nome_func = @nome";
            cmd.Parameters.AddWithValue("@nomeNovo", func.Nome);
            cmd.Parameters.AddWithValue("@senha", func.Senha);
            cmd.Parameters.AddWithValue("@nome", StaticKeys.Usuario);
            cmd.Parameters.AddWithValue("@foto", imagem_byte);

            try
            {
                cmd.ExecuteNonQuery();
                con.Desconectar();
                StaticKeys.Usuario = func.Nome;
                StaticKeys.Senha = func.Senha;
                BitmapImage image = new BitmapImage();
                MemoryStream ms = new MemoryStream(imagem_byte);
                image.BeginInit();
                image.StreamSource = ms;
                image.EndInit();
                StaticKeys.caminhoImagem = image;
                Erro = false;
                return true;
            }
            catch (SqlException)
            {
                Erro = true;
                return false;
                throw;
            }

        }
    }
}
