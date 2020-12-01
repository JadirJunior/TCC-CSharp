using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjTreino
{
    public class NotificationMessage
    {
        private string _message = "";
        private string _title = "";
        private string _icon = "";

        public string Message { get => _message; set => _message = value; }

        public string Title { get => _title; set => _title = value; }

        public string Icon { get => _icon; set => _icon = value; }
    }

    public class NotificationError : NotificationMessage
    {
        public NotificationError()
        {
            Title = "Erro";
        }
    }

    public class NotificationInformation : NotificationMessage
    {
        public NotificationInformation()
        {
            Title = "Erro";
        }
    }

    public class NotificationSucesfull : NotificationMessage
    {
        public NotificationSucesfull()
        {
            Title = "Bem vindo";
        }
    }
}
