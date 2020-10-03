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
    public class NotasCommands
    {
        Conexao con;
        SqlCommand cmd;
        SqlDataReader drb;
        List<Nota> notas = new List<Nota>();
        public List<Nota> getNotas(int idFunc)
        {

            con = new Conexao();
            cmd = new SqlCommand();

            cmd.CommandText = "select * from notas where idFunc = @n";
            cmd.Parameters.AddWithValue("@n", idFunc);
            try
            {
                cmd.Connection = con.Conectar();
                drb = cmd.ExecuteReader();

                while (drb.Read())
                {
                    notas.Add(new Nota() {
                        Content = drb["Content"].ToString(),
                        IdFunc = (int) drb["idFunc"]
                    });
                }
                con.Desconectar();
                return notas;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um Erro, Tente novamente!");
                throw;
            }
        }
        
        public bool addNota(Nota nota)
        {
            con = new Conexao();
            cmd = new SqlCommand();

            cmd.CommandText = "insert into notas (idFunc, Content) values  (@id,@content) ";
            cmd.Parameters.AddWithValue("@id", nota.IdFunc);
            cmd.Parameters.AddWithValue("@content", nota.Content);
            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
                con.Desconectar();

                if (StaticKeys.Notas == null) StaticKeys.Notas = new List<Nota>();

                StaticKeys.Notas.Add(nota);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool removeNota(Nota nota)
        {
            con = new Conexao();
            cmd = new SqlCommand();

            cmd.CommandText = "delete from notas where idFunc = @id and Content = @content";
            cmd.Parameters.AddWithValue("@id", nota.IdFunc);
            cmd.Parameters.AddWithValue("@content", nota.Content);
            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
                con.Desconectar();

                StaticKeys.Notas.Remove(nota);

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
