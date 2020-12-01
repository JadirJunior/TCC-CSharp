using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjTreino.DAL.models
{
    public class Nota
    {
        private String content;
        private int idFunc;

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

        public int IdFunc
        {
            get
            {
                return idFunc;
            }
            set
            {
                idFunc = value;
            }
        }

    }
}
