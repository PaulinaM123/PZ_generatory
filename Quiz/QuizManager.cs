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
        int howManyQuestionInQuiz = 8;
        int actualQuestion = 0;
        int howManyQuestionInCategory;
        StackPanel questionPlace;

        public QuizManager(int categoryId, StackPanel questionPlace)
        {
            List<Question> allQuestionFromCategory = loadQuestionByCategory(categoryId);
            howManyQuestionInCategory = allQuestionFromCategory.Count();
            randXQuestionsFromAll(allQuestionFromCategory);
            this.questionPlace = questionPlace;
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
            while (numbers.Count < howManyQuestionInQuiz - 1)
            {
                numbers.Add(rnd.Next(0, allQuestionFromCategory.Count));
            }

            foreach (var item in numbers)
            {
                _questions.Add(allQuestionFromCategory[item]);
            }
        }

        private void QuestionEndedEvent(object sender, EventArgs e)
        {
            Console.WriteLine("-----------------------------------------------------------------------------");

            NextQuestion();
        }

        public void NextQuestion()
        {
            UserControl a;
            if (actualQuestion >= howManyQuestionInQuiz - 1)
            {
                a = new EndQuizUserControl(_questions[1]);
            }
            else
            {
                a = new UserControlQuestion(_questions[actualQuestion], new EventHandler(QuestionEndedEvent), actualQuestion);
                actualQuestion++;
            }
            questionPlace.Children.Clear();
            questionPlace.Children.Add(a);
        }
    }
}
