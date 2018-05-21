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
    /// Interaction logic for UserControlGeneratory.xaml
    /// </summary>
    public partial class UserControlGeneratory : UserControl
    {
        public UserControlGeneratory()
        {
            InitializeComponent();

            LoadGeenratorsName();
        }

        private void LoadGeenratorsName()
        {
            List<string> generators = new List<string>();
            generators.Add("Generator Progowy");
            generators.Add("Generatora Samodecydującego Rueppela");
            generators.Add("Generator Rozrzedzający");
            generators.Add("Generator Geffego");
            generators.Add("Przemienny Generator stop-and-go");
            generators.Add("Kaskada Gollmana");
            generators.Add("Generator Obcinający");
            generators.Add("Generator Samoobcinający");


            ItemContorlWrapPranel.ItemsSource = generators;
        }

        SolidColorBrush active = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF224BB6"));
        SolidColorBrush normal = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF267BB6"));

        private void Button_Click(object sender, RoutedEventArgs e)
        {
             UserControl usc = new UserControl_rozrzedzający();
            UserControlChange.Children.Add(usc);
        }
    }
}
