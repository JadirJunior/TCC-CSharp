using PrjTreino.DAL.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PrjTreino.DAL
{
    public class PostagemCommands
    {
        Conexao con;
        SqlCommand cmd;
        SqlDataReader drb;
        List<Postagem> postagens = new List<Postagem>();

        public List<Postagem> getPostagens()
        {
            con = new Conexao();
            cmd = new SqlCommand();
            cmd.CommandText = "select * from postagens";
            try
            {
                cmd.Connection = con.Conectar();
                drb = cmd.ExecuteReader();
                if (!drb.HasRows) return new List<Postagem>();
                while (drb.Read())
                {
                    String funcName = new FuncCommands().selectFuncNameById((int)drb["idFunc"]);

                    postagens.Add(new Postagem() {
                        AuthorId = (int) drb["idFunc"],
                        AuthorName = funcName,
                        Content = drb["Content"].ToString()
                    });

                }
                con.Desconectar();
                drb.Close();
                return postagens;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um Erro!");
                throw;
            }
        }

        public bool addPostagem(Postagem postagem)
        {
            con = new Conexao();
            cmd = new SqlCommand();
            cmd.CommandText = "insert into postagens (idFunc, Content) values (@id, @content)";
            cmd.Parameters.AddWithValue("@id", postagem.AuthorId);
            cmd.Parameters.AddWithValue("@content", postagem.Content);
            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
                StaticKeys.Postagens.Add(postagem);
                con.Desconectar();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool deletePostagem(Postagem postagem)
        {
            con = new Conexao();
            cmd = new SqlCommand();
            cmd.CommandText = "delete from postagens where content = @id";
            cmd.Parameters.AddWithValue("@id", postagem.Content);
            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
                StaticKeys.Postagens.Remove(postagem);
                con.Desconectar();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
    }
}
