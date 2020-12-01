using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjTreino.DAL.models
{
    public class Postagem
    {
        private String authorName;
        private int authorId;
        private String content;

        public String AuthorName
        {
            get
            {
                return authorName;
            }

            set
            {
                authorName = value;
            }
        }

        public int AuthorId
        {
            get => authorId;

            set => authorId = value;
        }

        public String Content
        {
            get => content;

            set => content = value;
        }
    }
}
