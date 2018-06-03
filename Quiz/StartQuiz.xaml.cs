using System.Windows;
using System.Windows.Controls;


namespace PZ_generatory.Quiz
{

    public partial class StartQuiz : UserControl
    {
        public string categoryName { get; set; }
        public int categoryId { get; set; }

        QuizManager quizmanager;

        public StartQuiz(int categoryid, string categoryname)
        {
            InitializeComponent();
            this.quizmanager = new QuizManager(categoryId, QuestionPlace, QuestionNumberLabel);
            this.categoryName = categoryname;
            this.categoryId = categoryid;
            LabelCategoryChoice.Content = "Wybrana kategoria: " + categoryName;
        }

        private void buttonBackToCAtegoryChoice_Click(object sender, RoutedEventArgs e)
        {
            (this.Parent as Panel).Children.Remove(this);
        }

        private void buttonQuiz_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (quizmanager.actualQuestion == 0)
            {
                button.Content = "Następne pytanie";
                buttonBackToCAtegoryChoice.Visibility = Visibility.Hidden;
                quizmanager.NextQuestion();
            }
            else if(quizmanager.actualQuestion >= quizmanager.howManyQuestionInQuiz)
            {
                button.Content = "Wróć do wyboru kategorii";
                button.Click -= buttonQuiz_Click;
                button.Click += buttonBackToCAtegoryChoice_Click;

                var a = (UserControlQuestion)QuestionPlace.Children[0];
                a.EndQuestion(e);
            }
            else
            {
                var a = (UserControlQuestion)QuestionPlace.Children[0];
                a.EndQuestion(e);
                 
            }
            
        }
    }
}
