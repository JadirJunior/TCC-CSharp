using MaterialDesignThemes.Wpf;
using PrjTreino.userControls.Classes;
using PrjTreino.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PrjTreino.userControls
{
    /// <summary>
    /// Interação lógica para Calendario.xam
    /// </summary>
    public partial class Calendario : UserControl
    {
        public bool iniciou = false;
        public String dayNumber { get; set; }
        public String dayString { get; set; }
        List<Compromisso> compromissos = new List<Compromisso>();
        private void setBlackout()
        {
            calendario.SelectedDates.Add(new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day));
            StaticKeys.dataMarcada = Convert.ToDateTime(calendario.SelectedDate);
            iniciou = true;
        }

        public Calendario()
        {
            InitializeComponent();
            dayNumber = DateTime.Today.Day.ToString();
            dayString = DateTime.Today.DayOfWeek.ToString();
            DiaNumero.Text = dayNumber;
            DiaNome.Text = dayString;
            setBlackout();
            verificarCompromissos();
        }

        public void verificarCompromissos()
        {
            if (StaticKeys.compromissos == null)
            {
                datasMarcadas.Children.Clear();
                datasMarcadas.Children.Add(new TextBlock() { Text = "Nenhum compromisso para este dia!" });
                return;
            }

            var resultado = StaticKeys.compromissos.Where(x => x.Data == Convert.ToDateTime(calendario.SelectedDate));
            if (resultado.Count() < 1)
            {
                datasMarcadas.Children.Clear();
                datasMarcadas.Children.Add(new TextBlock() { Text = "Nenhum compromisso para este dia!" });
            }
            else
            {
                datasMarcadas.Children.Clear();
                foreach (Compromisso res in resultado)
                {
                    datasMarcadas.Children.Add(new TextBlock() { Text = res.Nome });
                }
            }
        }

        private void Calendario_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            if (iniciou)
            {
                dayNumber = calendario.SelectedDate.Value.ToString().Substring(0, 2);
                DateTime dia = Convert.ToDateTime(calendario.SelectedDate);
                StaticKeys.dataMarcada = dia;
                dayString = dia.DayOfWeek.ToString();
                DiaNome.Text = dayString;
                DiaNumero.Text = dayNumber;
                verificarCompromissos();
            }
            
        }

        private async void mostra()
        {
        }

        private void Calendario_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            CalendarioBox calendarioBox = new CalendarioBox();
            calendarioBox.ShowDialog();
        }

        private void BtnSalva_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
