using PZ_generatory.Quiz;
using System;
using System.Collections.Generic;
using System.Data.Linq;
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
    /// Interaction logic for UserControlQuizTematyczny.xaml
    /// </summary>
    public partial class UserControlQuizTematyczny : UserControl
    {

        public UserControlQuizTematyczny()
        {
            InitializeComponent();

            LoadCategoriesToWrapPanelFromDataBase();
        }

        private void LoadCategoriesToWrapPanelFromDataBase()
        {
            var db = new DBLinqClassesDataContext();
            var categories = db.Categories;
            ItemContorlWrapPranel.ItemsSource = categories;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UserControl usc = new StartQuiz();
            GridMain.Children.Add(usc);
        }
    }
}
