using PrjTreino.DAL.models;
using PrjTreino.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace PrjTreino.DAL
{
    public class FuncCommands
    {
        private Conexao con;
        private SqlCommand cmd;
        private SqlDataReader drb;
        private List<Funcionario> funcionarios = new List<Funcionario>();

        public List<Funcionario> selectAllFuncs()
        {
            con = new Conexao();
            cmd = new SqlCommand();
            cmd.CommandText = "select * from funcionarios where nome_func != @n";
            cmd.Parameters.AddWithValue("@n", StaticKeys.Usuario);
            try
            {
                cmd.Connection = con.Conectar();
                drb = cmd.ExecuteReader();
                while (drb.Read())
                {
                    funcionarios.Add(new Funcionario(
                        drb["nome_func"].ToString(),
                        drb["senha_func"].ToString(),
                        (int)drb["id_func"],
                        drb["foto_func"] == DBNull.Value || drb["foto_func"].ToString() == " " ?
                        new BitmapImage(new Uri("/assets/imageDefault.png", UriKind.Relative)) :
                        Conversions.dataReaderToBitmapImage(drb)
                        )); 
                }
                StaticKeys.funcionarios = funcionarios;
                con.Desconectar();
                drb.Close();
                return StaticKeys.funcionarios;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro. Tente novamente.");
                throw;
            }
        }

        public String selectFuncNameById(int id)
        {
            con = new Conexao();
            cmd = new SqlCommand();
            cmd.CommandText = "select * from funcionarios where id_func = @n";
            cmd.Parameters.AddWithValue("@n", id);
            try
            {
                cmd.Connection = con.Conectar();
                drb = cmd.ExecuteReader();

                if (!drb.HasRows) return "";
                String nomeFunc = "";
                while (drb.Read())
                {
                    nomeFunc = drb["nome_func"].ToString();
                }
                con.Desconectar();
                drb.Close();
                return nomeFunc;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro. Tente novamente.");
                throw;
            }
        }
    }
}
