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
using System.Windows.Shapes;

namespace BootlegSteam
{
    /// <summary>
    /// Interaction logic for MenuWarning.xaml
    /// </summary>
    public partial class MenuWarning : Window
    {
        public MenuWarning()
        {
            InitializeComponent();
        }

        private void closewarning_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
