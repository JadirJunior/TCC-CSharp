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
            con.ConnectionString = @"Initial Catalog = DB_SITE; Integrated Security = TRUE; Data Source=" + Environment.MachineName;
        }

        public LoginComands LoginComands
        {
            get => default;
            set
            {
            }
        }

        public FuncCommands FuncCommands
        {
            get => default;
            set
            {
            }
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
