using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjTreino.userControls
{
    public class Meses
    {
        Dictionary<int, String> meses = new Dictionary<int, string>();

        public Meses()
        {
            meses.Add(1, "Janeiro");
            meses.Add(2, "Fevereiro");
            meses.Add(3, "Março");
            meses.Add(4, "Abril");
            meses.Add(5, "Maio");
            meses.Add(6, "Junho");
            meses.Add(7, "Julho");
            meses.Add(8, "Agosto");
            meses.Add(9, "Setembro");
            meses.Add(10, "Outubro");
            meses.Add(11, "Novembro");
            meses.Add(12, "Dezembro");
        }

        public String selecionarMes(int key)
        {
            String mes = "";
            var mesSelecionado = meses.Where(x=> x.Key == key);
            foreach (KeyValuePair<int, String> valor in mesSelecionado)
            {
                return valor.Value;
            }
            return mes;
        }
    }
}
