using MaterialDesignThemes.Wpf;
using PrjTreino.Controles;
using PrjTreino.DAL.models;
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
    /// Lógica interna para NotasBox.xaml
    /// </summary>
    public partial class NotasBox : Window
    {
        public NotasBox()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {

            if (txtNota.Text == "") return;

            //if (StaticKeys.Notas == null)
            //    StaticKeys.Notas = new List<Nota>();

            //StaticKeys.Notas.Add(new Nota() {
            //    Content = txtNota.Text,
            //    IdFunc = StaticKeys.id_func
            //});

            new NotaController().addNota(new Nota()
            {
                Content = txtNota.Text,
                IdFunc = StaticKeys.id_func
            });

            txtNota.Text = "";
            Mural.renderNotas();

        }


        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
