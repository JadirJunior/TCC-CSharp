using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjTreino.userControls.Classes
{

    public class Compromisso
    {
        private String nome;
        private DateTime data;
        private String nome_func;
        private int id_func;

        public int IdFunc
        {
            get
            {
                return id_func;
            }
            set
            {
                id_func = value;
            }
        }

        public String Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }

        public DateTime Data
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
            }
        }

        public String Nome_func
        {
            get
            {
                return nome_func;
            }
            set
            {
                nome_func = value;
            }
        }
    }
}
