using PrjTreino.userControls.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjTreino.DAL
{
    public class calendarioComandos
    {
        Conexao con;
        SqlCommand cmd;
        SqlDataReader drb;
        public bool Erro = false;
        public void selecionarCompromissos(int id_func)
        {
            con = new Conexao();
            cmd = new SqlCommand();
            cmd.CommandText = "select * from Compromissos where id_func = @id";
            cmd.Parameters.AddWithValue("@id", id_func);
            try
            {
                List<Compromisso> compromissos = new List<Compromisso>();
                cmd.Connection = con.Conectar();
                drb = cmd.ExecuteReader();
                while (drb.Read())
                {
                    
                        compromissos.Add(new Compromisso() {
                            Nome = drb["nome_compromisso"].ToString(),
                            IdFunc = (int)drb["id_func"],
                            Data = Convert.ToDateTime(drb["dia"])
                        });
                }
                if (compromissos != null)
                    StaticKeys.compromissos = compromissos;
                Erro = false;
                drb.Close();
                con.Desconectar();
            }
            catch (SqlException)
            {
                Erro = true;
                throw;
            }
        }

        public void cadastrarData(Compromisso compromisso)
        {
            con = new Conexao();
            cmd = new SqlCommand();
            cmd.CommandText = "insert into Compromissos (id_func, nome_compromisso, dia) values (@id, @nome, @dia)";
            cmd.Parameters.AddWithValue("@id", compromisso.IdFunc);
            cmd.Parameters.AddWithValue("@nome", compromisso.Nome);
            cmd.Parameters.AddWithValue("@dia", compromisso.Data);
            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
                Erro = false;
                con.Desconectar();
            }
            catch (SqlException)
            {
                Erro = true;
                throw;
            }
        }
    }
}
