﻿using PZ_generatory.Generators.Rozrzedzajacy;
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
    /// Interaction logic for UserControl_rozrzedzający.xaml
    /// </summary>
    public partial class UserControl_rozrzedzający : UserControl
    {
        public UserControl_rozrzedzający()
        {
            InitializeComponent();
        }

        private void Wykorzystaj_Click(object sender, RoutedEventArgs e)
        {
            UserControl usc = null;
            GridRzrzedzajacy.Children.Clear();
            usc = new Ustawienia_rozrzedzajacy();
            GridRzrzedzajacy.Children.Add(usc);
        }
    }
}
