using SocketIOSharp.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjTreino.Utils
{
    public class Message
    {
        public static Message message;
        private String author;
        private String content;
        private String destinatario;

        public Message()
        {
            message = this;
        }

        public String Destinatario
        {
            get
            {
                return destinatario;
            }

            set
            {
                destinatario = value;
            }
        }


        public String Author
        {
            get
            {
                return author;
            }
            set
            {
                author = value;
            }
        }

        public String Content
        {
            get
            {
                return content;
            }
            set
            {
                content = value;
            }
        }
    }
}
