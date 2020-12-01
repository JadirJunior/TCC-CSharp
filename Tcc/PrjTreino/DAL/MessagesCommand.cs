using PrjTreino.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PrjTreino.DAL
{
    public class MessagesCommand
    {
        Conexao con;
        SqlCommand cmd;
        SqlDataReader drb;
        List<Message> messages = new List<Message>();
        

        public List<Message> carregarMensagens()
        {
            con = new Conexao();
            cmd = new SqlCommand();
            cmd.CommandText = "select * from mensagens";
            try
            {
                cmd.Connection = con.Conectar();
                drb = cmd.ExecuteReader();
                while (drb.Read())
                {
                    Message mensagem = new Message()
                    {
                        Author = drb["Author"].ToString(),
                        Content = drb["Content"].ToString(),
                        Destinatario = drb["Destinatario"].ToString()
                    };
                    messages.Add(mensagem);
                }
                con.Desconectar();

                return messages;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro inesperado. Tente Novamente.");
                throw;
            }
        }
    }
}
