using PrjTreino.DAL;
using PrjTreino.DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PrjTreino.Controles
{
   public class NotaController
    {
        List<Nota> notas = new List<Nota>();
        public List<Nota> getNotas()
        {
            notas = new NotasCommands().getNotas(StaticKeys.id_func);
            return notas;
        }

        public void addNota(Nota nota)
        {
            bool res = new NotasCommands().addNota(nota);
            if (res) return;
            MessageBox.Show("Ocorreu um Erro!");
        }

        public void removeNota(Nota nota)
        {
            bool res = new NotasCommands().removeNota(nota);
            if (res) return;
        }
    }
}
