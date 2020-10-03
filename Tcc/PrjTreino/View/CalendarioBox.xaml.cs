using PrjTreino.Controles;
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
using System.Windows.Shapes;

namespace PrjTreino.View
{
    /// <summary>
    /// Lógica interna para CalendarioBox.xaml
    /// </summary>
    public partial class CalendarioBox : Window
    {
        calendarioControler calendarioControler;
        public CalendarioBox()
        {
            InitializeComponent();
        }
        private bool cadastrarCompromisso(List<Compromisso> compromissos)
        {
            calendarioControler = new calendarioControler();
           return calendarioControler.cadastrarCompromisso(compromissos[0]);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<Compromisso> compromissos = new List<Compromisso>();
            compromissos.Add(new Compromisso()
            {
                Nome = txtComp.Text,
                Data = StaticKeys.dataMarcada,
                IdFunc = StaticKeys.id_func,
                Nome_func = StaticKeys.Usuario
            });
           if  (cadastrarCompromisso(compromissos))
            {
                if (StaticKeys.compromissos == null)
                {
                    StaticKeys.compromissos = compromissos;
                }
                else
                {
                    StaticKeys.compromissos.Add(compromissos[0]);
                }

            } else
            {
                MessageBox.Show("Ocorreu algum erro, tente novamente...", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
                compromissos = null;
            }

            
            txtComp.Text = "";
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
