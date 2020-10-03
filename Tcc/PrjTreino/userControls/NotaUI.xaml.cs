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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PrjTreino.userControls
{
    /// <summary>
    /// Interação lógica para NotaUI.xam
    /// </summary>
    public partial class NotaUI : UserControl
    {
        public NotaUI(String content)
        {
            InitializeComponent();
            NotaContent.Text = content;
        }

        private void BtnExcluir_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
           var notas = StaticKeys.Notas.Where(x => x.Content == NotaContent.Text);
           List<Nota> notasList = notas.ToList(); 

           foreach (Nota nota in notasList)
            {
                new NotaController().removeNota(nota);
            }

            Mural.renderNotas();
        }
    }
}
