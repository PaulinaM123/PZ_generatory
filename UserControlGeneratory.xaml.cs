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
        }

        private void Progowy_Click(object sender, RoutedEventArgs e)
        {
            ContentProgowy.Visibility = Visibility.Visible;
            ContentRueppela.Visibility = Visibility.Hidden;
            ContentRozrzedzający.Visibility = Visibility.Hidden;
            ContentGeffego.Visibility = Visibility.Hidden;
            ContentStop_and_go.Visibility = Visibility.Hidden;
            ContentGollmana.Visibility = Visibility.Hidden;
            ContentObcinający.Visibility = Visibility.Hidden;
            ContentSamoobcinający.Visibility = Visibility.Hidden;
            SolidColorBrush active= new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF224BB6"));
            SolidColorBrush normal = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF267BB6"));
            Progowy.Background = active;
            Rueppela.Background = normal;
            Rozrzedzający.Background = normal;
            Geffego.Background = normal;
            Stop_and_go.Background = normal;
            Gollmana.Background = normal;
            Obcinający.Background = normal;
            Samoobcinający.Background = normal;
        }

        private void Rueppela_Click(object sender, RoutedEventArgs e)
        {
            ContentProgowy.Visibility = Visibility.Hidden;
            ContentRueppela.Visibility = Visibility.Visible;
            ContentRozrzedzający.Visibility = Visibility.Hidden;
            ContentGeffego.Visibility = Visibility.Hidden;
            ContentStop_and_go.Visibility = Visibility.Hidden;
            ContentGollmana.Visibility = Visibility.Hidden;
            ContentObcinający.Visibility = Visibility.Hidden;
            ContentSamoobcinający.Visibility = Visibility.Hidden;
            SolidColorBrush active = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF224BB6"));
            SolidColorBrush normal = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF267BB6"));
            Progowy.Background = normal;
            Rueppela.Background = active;
            Rozrzedzający.Background = normal;
            Geffego.Background = normal;
            Stop_and_go.Background = normal;
            Gollmana.Background = normal;
            Obcinający.Background = normal;
            Samoobcinający.Background = normal;
        }

        private void Rozrzedzający_Click(object sender, RoutedEventArgs e)
        {
            ContentProgowy.Visibility = Visibility.Hidden;
            ContentRueppela.Visibility = Visibility.Hidden;
            ContentRozrzedzający.Visibility = Visibility.Visible;
            ContentGeffego.Visibility = Visibility.Hidden;
            ContentStop_and_go.Visibility = Visibility.Hidden;
            ContentGollmana.Visibility = Visibility.Hidden;
            ContentObcinający.Visibility = Visibility.Hidden;
            ContentSamoobcinający.Visibility = Visibility.Hidden;
            SolidColorBrush active = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF224BB6"));
            SolidColorBrush normal = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF267BB6"));
            Progowy.Background = normal;
            Rueppela.Background = normal;
            Rozrzedzający.Background = active;
            Geffego.Background = normal;
            Stop_and_go.Background = normal;
            Gollmana.Background = normal;
            Obcinający.Background = normal;
            Samoobcinający.Background = normal;
        }

        private void Geffego_Click(object sender, RoutedEventArgs e)
        {
            ContentProgowy.Visibility = Visibility.Hidden;
            ContentRueppela.Visibility = Visibility.Hidden;
            ContentRozrzedzający.Visibility = Visibility.Hidden;
            ContentGeffego.Visibility = Visibility.Visible;
            ContentStop_and_go.Visibility = Visibility.Hidden;
            ContentGollmana.Visibility = Visibility.Hidden;
            ContentObcinający.Visibility = Visibility.Hidden;
            ContentSamoobcinający.Visibility = Visibility.Hidden;
            SolidColorBrush active = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF224BB6"));
            SolidColorBrush normal = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF267BB6"));
            Progowy.Background = normal;
            Rueppela.Background = normal;
            Rozrzedzający.Background = normal;
            Geffego.Background = active;
            Stop_and_go.Background = normal;
            Gollmana.Background = normal;
            Obcinający.Background = normal;
            Samoobcinający.Background = normal;
        }

        private void Stop_and_go_Click(object sender, RoutedEventArgs e)
        {
            ContentProgowy.Visibility = Visibility.Hidden;
            ContentRueppela.Visibility = Visibility.Hidden;
            ContentRozrzedzający.Visibility = Visibility.Hidden;
            ContentGeffego.Visibility = Visibility.Hidden;
            ContentStop_and_go.Visibility = Visibility.Visible;
            ContentGollmana.Visibility = Visibility.Hidden;
            ContentObcinający.Visibility = Visibility.Hidden;
            ContentSamoobcinający.Visibility = Visibility.Hidden;
            SolidColorBrush active = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF224BB6"));
            SolidColorBrush normal = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF267BB6"));
            Progowy.Background = normal;
            Rueppela.Background = normal;
            Rozrzedzający.Background = normal;
            Geffego.Background = normal;
            Stop_and_go.Background = active;
            Gollmana.Background = normal;
            Obcinający.Background = normal;
            Samoobcinający.Background = normal;
        }

        private void Gollmana_Click(object sender, RoutedEventArgs e)
        {
            ContentProgowy.Visibility = Visibility.Hidden;
            ContentRueppela.Visibility = Visibility.Hidden;
            ContentRozrzedzający.Visibility = Visibility.Hidden;
            ContentGeffego.Visibility = Visibility.Hidden;
            ContentStop_and_go.Visibility = Visibility.Hidden;
            ContentGollmana.Visibility = Visibility.Visible;
            ContentObcinający.Visibility = Visibility.Hidden;
            ContentSamoobcinający.Visibility = Visibility.Hidden;
            SolidColorBrush active = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF224BB6"));
            SolidColorBrush normal = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF267BB6"));
            Progowy.Background = normal;
            Rueppela.Background = normal;
            Rozrzedzający.Background = normal;
            Geffego.Background = normal;
            Stop_and_go.Background = normal;
            Gollmana.Background = active;
            Obcinający.Background = normal;
            Samoobcinający.Background = normal;
        }

        private void Obcinający_Click(object sender, RoutedEventArgs e)
        {
            ContentProgowy.Visibility = Visibility.Hidden;
            ContentRueppela.Visibility = Visibility.Hidden;
            ContentRozrzedzający.Visibility = Visibility.Hidden;
            ContentGeffego.Visibility = Visibility.Hidden;
            ContentStop_and_go.Visibility = Visibility.Hidden;
            ContentGollmana.Visibility = Visibility.Hidden;
            ContentObcinający.Visibility = Visibility.Visible;
            ContentSamoobcinający.Visibility = Visibility.Hidden;
            SolidColorBrush active = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF224BB6"));
            SolidColorBrush normal = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF267BB6"));
            Progowy.Background = normal;
            Rueppela.Background = normal;
            Rozrzedzający.Background = normal;
            Geffego.Background = normal;
            Stop_and_go.Background = normal;
            Gollmana.Background = normal;
            Obcinający.Background = active;
            Samoobcinający.Background = normal;
        }

        private void Samoobcinający_Click(object sender, RoutedEventArgs e)
        {
            ContentProgowy.Visibility = Visibility.Hidden;
            ContentRueppela.Visibility = Visibility.Hidden;
            ContentRozrzedzający.Visibility = Visibility.Hidden;
            ContentGeffego.Visibility = Visibility.Hidden;
            ContentStop_and_go.Visibility = Visibility.Hidden;
            ContentGollmana.Visibility = Visibility.Hidden;
            ContentObcinający.Visibility = Visibility.Hidden;
            ContentSamoobcinający.Visibility = Visibility.Visible;
            SolidColorBrush active = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF224BB6"));
            SolidColorBrush normal = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF267BB6"));
            Progowy.Background = normal;
            Rueppela.Background = normal;
            Rozrzedzający.Background = normal;
            Geffego.Background = normal;
            Stop_and_go.Background = normal;
            Gollmana.Background = normal;
            Obcinający.Background = normal;
            Samoobcinający.Background = active;
        }
    }
}
