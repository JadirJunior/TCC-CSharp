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

namespace PrjTreino.userControls.Chat
{
    /// <summary>
    /// Interação lógica para ChatInfo.xam
    /// </summary>
    public partial class ChatInfo : UserControl
    {
        public ChatInfo()
        {
            InitializeComponent();
        }

        public ChatInfo(String name)
        {
            InitializeComponent();
            txtNome.Text = name;
        }

        public ChatInfo(String name, BitmapImage img)
        {
            InitializeComponent();
            txtNome.Text = name;
            imgFunc.Source = img;
        }
    }
}
