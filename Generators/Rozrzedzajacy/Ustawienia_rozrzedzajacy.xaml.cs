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

namespace PZ_generatory.Generators.Rozrzedzajacy
{
    /// <summary>
    /// Interaction logic for Ustawienia_rozrzedzajacy.xaml
    /// </summary>
    public partial class Ustawienia_rozrzedzajacy : UserControl
    {
        public Ustawienia_rozrzedzajacy()
        {
            InitializeComponent();
        }

        private void Wygeneruj_Click(object sender, RoutedEventArgs e)
        {
            UserControl usc = null;
            GridUstawienia.Children.Clear();
            usc = new Output_rozrzedzajacy();
            GridUstawienia.Children.Add(usc);
        }
    }
}
