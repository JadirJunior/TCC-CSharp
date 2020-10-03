using PrjTreino.DAL;
using PrjTreino.DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjTreino.Controles
{
    public class FuncControler
    {
        FuncCommands commands = new FuncCommands();
        private List<Funcionario> funcs;

        public Funcionario Funcionario
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

        public List<Funcionario> selectAllFuncs()
        {
            funcs = commands.selectAllFuncs();
            return funcs;
        }
    }
}
