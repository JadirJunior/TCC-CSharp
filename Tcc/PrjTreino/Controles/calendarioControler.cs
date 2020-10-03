using PrjTreino.DAL;
using PrjTreino.userControls.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjTreino.Controles
{
   public class calendarioControler
    {
        public bool Erro = false;
        calendarioComandos calendarioComandos;
        public bool selecionarCalendario(int id_func)
        {
            calendarioComandos = new calendarioComandos();
            calendarioComandos.selecionarCompromissos(id_func);
            if (calendarioComandos.Erro)
            {
                return false;
            }
            return true;
        }

        public bool cadastrarCompromisso(Compromisso compromisso)
        {
            calendarioComandos = new calendarioComandos();
            calendarioComandos.cadastrarData(compromisso);
            if (calendarioComandos.Erro)
                return false;
            return true;
        }
    }
}
