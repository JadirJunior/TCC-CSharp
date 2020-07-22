using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjTreino.DAL
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection();

        public Conexao()
        {
            con.ConnectionString = @"Initial Catalog = PrjTCCteste; Integrated Security = TRUE; Data Source="+Environment.MachineName;
        }

        public SqlConnection Conectar()
        {
            if (con.State.Equals(System.Data.ConnectionState.Closed))
                con.Open();

            return con;
        }

        public void Desconectar()
        {
            if (con.State.Equals(System.Data.ConnectionState.Open))
                con.Close();
        }

    }
}
