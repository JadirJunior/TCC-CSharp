using LiveCharts;
using MaterialDesignThemes.Wpf;
using PrjTreino.userControls.Classes;
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
    /// Interação lógica para Status.xam
    /// </summary>
    public partial class Status : UserControl
    {
        Dictionary<int, String> prazos = new Dictionary<int, String>();
        Items Items = new Items(); 
        public String Header { get; set; }
        public ChartValues<double> Values1 { get; set; }
        public ChartValues<String> Labels { get; set; }
        public Status()
        {
            InitializeComponent();
            prazos = Items.items;
            Header = "6 meses";
            alterarDadosGrafico(1);
            DataContext = this;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (var item in prazos)
            {
                lista.Items.Add(item.Value);
            }
        }

        private void Lista_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Header = lista.SelectedItem.ToString();
            expander.Header = Header;
            messageBox.IsOpen = true;
            expander.IsExpanded = false;
            var prazo = prazos.Where(x => x.Value == Header);
            foreach (KeyValuePair<int, String> key in prazo)
            {
                alterarDadosGrafico(key.Key);
            }
        }

        private void alterarDadosGrafico(int key)
        {
            if (key == 1)
            {
                Values1 = new ChartValues<double> { 50, 100, 200, 300, 350, 400 };
                Labels = new ChartValues<string> {
                    selecionaMes(DateTime.Today.Month - 6),
                    selecionaMes(DateTime.Today.Month - 5),
                    selecionaMes(DateTime.Today.Month - 4),
                    selecionaMes(DateTime.Today.Month - 3),
                    selecionaMes(DateTime.Today.Month - 2),
                    selecionaMes(DateTime.Today.Month - 1) };
                valores.Values = Values1;
                labels.Labels = Labels;
            } else if(key==2)
            {
                Values1 = new ChartValues<double> { 200, 300, 400 };
                Labels = new ChartValues<string> {
                    selecionaMes(DateTime.Today.Month - 3),
                    selecionaMes(DateTime.Today.Month - 2),
                    selecionaMes(DateTime.Today.Month - 1)
                };
                valores.Values = Values1;
                labels.Labels = Labels;
            }

            else if (key == 3)
            {
                Values1 = new ChartValues<double> { 200, 300};
                Labels = new ChartValues<string> {
                    selecionaMes(DateTime.Today.Month - 1),
                    "Hoje"
                };
                valores.Values = Values1;
                labels.Labels = Labels;
            }
            else if (key == 4)
            {
                Values1 = new ChartValues<double> { 200, 300, 400, 500, 600, 650, 700 };
                Labels = new ChartValues<string> {
                    (DateTime.Today.Day-6).ToString(),
                    (DateTime.Today.Day-5).ToString(),
                    (DateTime.Today.Day-4).ToString(),
                    (DateTime.Today.Day-3).ToString(),
                    (DateTime.Today.Day-2).ToString(),
                    (DateTime.Today.Day-1).ToString(),
                    (DateTime.Today.Day).ToString()
                };
                valores.Values = Values1;
                labels.Labels = Labels;
            }
        }

        private String selecionaMes(int mes)
        {
            Meses meses = new Meses();
            String valor = meses.selecionarMes(mes);
            return valor;
        }


    }
}
