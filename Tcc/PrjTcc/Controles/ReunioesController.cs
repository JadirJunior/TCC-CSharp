using PrjTreino.userControls.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PrjTreino.Controles
{
    public class ReunioesController
    {
         List<Compromisso> compromissos = new List<Compromisso>();

        public List<Compromisso> getReuniao()
        {
            var lista = StaticKeys.compromissos.Where(comp => comp.Data.ToString() == DateTime.Today.ToString());

            foreach (Compromisso item in lista)
            {
                compromissos.Add(item);
            }
            return compromissos;
        }
    }
}
