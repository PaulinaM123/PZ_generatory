using PZ_generatory.Quiz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;

namespace PZ_generatory.Quiz
{
    class QuizManager
    {
        DBLinqClassesDataContext db = new DBLinqClassesDataContext();
        List<Question> _questions = new List<Question>();
        public int howManyQuestionInQuiz = 8;
        public int actualQuestion = 0;
        int howManyQuestionInCategory;
        StackPanel questionPlace;
        Label InfoAboutActualQuestion;
        bool[] UserAnswears;

        public QuizManager(int categoryId, StackPanel questionPlace, Label infoAboutActualQuestion)
        {
            List<Question> allQuestionFromCategory = loadQuestionByCategory(categoryId);
            howManyQuestionInCategory = allQuestionFromCategory.Count();
            randXQuestionsFromAll(allQuestionFromCategory);
            this.questionPlace = questionPlace;
            this.InfoAboutActualQuestion = infoAboutActualQuestion;
            this.UserAnswears = new bool[howManyQuestionInQuiz];
        }

        public int HowManyQuestionInCategory()
        {
            return howManyQuestionInCategory;
        }

        private List<Question> loadQuestionByCategory(int CategoryId)
        {
            return db.Questions.Where(s => s.CategoryId == CategoryId).ToList();
        }

        private void randXQuestionsFromAll(List<Question> allQuestionFromCategory)
        {
            HashSet<int> numbers = new HashSet<int>();
            var rnd = new Random();
            while (numbers.Count < howManyQuestionInQuiz )
            {
                numbers.Add(rnd.Next(0, allQuestionFromCategory.Count));
            }

            foreach (var item in numbers)
            {
                _questions.Add(allQuestionFromCategory[item]);
            }
        }

        public void QuestionEnded(object sender, EventArgs e)
        {
            var a = sender as UserControlQuestion;

            UserAnswears[actualQuestion-1] = a._isCorrect;

            NextQuestion();
        }

        public void NextQuestion()
        {
            UserControl a;
            if (actualQuestion > howManyQuestionInQuiz - 1)
            {
                InfoAboutActualQuestion.Content = "";

                int goodAnswer = 0;
                int badAnswer = 0;

                foreach (var item in UserAnswears)
                {
                    if (item == true)
                    {
                        goodAnswer++;
                    }else
                    {
                        badAnswer++;
                    }
                }
                a = new EndQuizUserControl(goodAnswer, UserAnswears.Length);
            }
            else
            {
                InfoAboutActualQuestion.Content = ((actualQuestion +1).ToString() + "/" + howManyQuestionInQuiz.ToString());
                a = new UserControlQuestion(_questions[actualQuestion], QuestionEnded, actualQuestion);
                actualQuestion++;
            }
            questionPlace.Children.Clear();
            questionPlace.Children.Add(a);
        }
    }
}
