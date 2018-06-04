<<<<<<< HEAD
<<<<<<< HEAD
﻿using System;
using System.Windows;
=======
﻿using System.Windows;
>>>>>>> parent of 4c588fb... Merge branch 'master' into Kamil
=======
﻿using System.Windows;
>>>>>>> parent of 4c588fb... Merge branch 'master' into Kamil
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
            this.quizmanager = new QuizManager(categoryId, QuestionPlace);
            this.categoryName = categoryname;
            this.categoryId = categoryid;
            LabelCategoryChoice.Content = "Wybrana kategoria: " + categoryName;
        }

        private void buttonBackToCAtegoryChoice_Click(object sender, RoutedEventArgs e)
        {
            (this.Parent as Panel).Children.Remove(this);
        }

        private void buttonStartQuiz_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            button.Content = "Następne pytanie";
            quizmanager.NextQuestion();

        }
    }
}
