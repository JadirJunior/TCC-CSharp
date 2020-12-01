﻿using System;
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
    /// Interação lógica para ItemMeet.xam
    /// </summary>
    public partial class ItemMeet : UserControl
    {
        public ItemMeet(String text)
        {
            InitializeComponent();
            MeetDescription.Text = text;
        }
    }
}
