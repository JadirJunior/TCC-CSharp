using PrjTreino.DAL;
using PrjTreino.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjTreino.Controles
{
    public class ControllerMessages
    {

        public static List<Message> getMessages()
        {
            MessagesCommand messages = new MessagesCommand();

            return messages.carregarMensagens();
        }
    }
}
