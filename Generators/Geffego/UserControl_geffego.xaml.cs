﻿using PZ_generatory.Generators.Geffego;
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

namespace PZ_generatory
{
    /// <summary>
    /// Interaction logic for UserControl_geffego.xaml
    /// </summary>
    public partial class UserControl_geffego : UserControl
    {
        public UserControl_geffego()
        {
            InitializeComponent();
        }

        private void Wykorzystaj_Click(object sender, RoutedEventArgs e)
        {
            UserControl usc = null;
            GridGeffego.Children.Clear();
            usc = new Settings_geffego();
            GridGeffego.Children.Add(usc);
        }
    }
}