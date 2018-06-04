using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace PZ_generatory.Quiz
{
    /// <summary>
    /// Interaction logic for Question.xaml
    /// </summary>
    public partial class UserControlQuestion : UserControl
    {
        SolidColorBrush _clickedColor = new SolidColorBrush(Color.FromArgb(0, 17, 79, 128));
        SolidColorBrush _standardColor = new SolidColorBrush(Color.FromArgb(0, 33, 150, 243));

        Question _Question;
        List<Answer> _Answears;
        bool[] _UserAnswear;
        bool _isCorrect;
        public int Questionnumber;

        public event EventHandler QuestionEnded;

        public UserControlQuestion(Question question, EventHandler QuestionEndedEvent, int questionNumber)
        {
            InitializeComponent();
            this._Question = question;
            this._Answears = loadAnswearsByQuestionID(_Question.Id);
            this._UserAnswear = new bool[4];
            this.QuestionEnded = QuestionEndedEvent;
            this._isCorrect = false;
            this.Questionnumber = questionNumber;
            fillConententOnPage();

            startTimer();
        }

        private List<Answer> loadAnswearsByQuestionID(int QuestionID)
        {
            var db = new DBLinqClassesDataContext();
            return db.Answers.Where(s => s.QuestionId == QuestionID).ToList();
        }

        private void startTimer()
        {
            TimerControl Timer = new TimerControl(_Question.Time, TimerCompletedEvent);
            TimerGrid.Children.Add(Timer);
        }

        private void TimerCompletedEvent(object sender, EventArgs e)
        {
            EndQuestion(e);
        }

        private void fillConententOnPage()
        {
            QuestionContent.Text = _Question.Content;

            question1.Text = _Answears[0].Content;
            question2.Text = _Answears[1].Content;
            question3.Text = _Answears[2].Content;
            question4.Text = _Answears[3].Content;
        }

        private void ButtonAnswear_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;

            var id = Int32.Parse(button.Name.Split('_')[1]);

            ChangeUserAnswear(id);
        }

        private void ChangeUserAnswear(int id)
        {
            if (_UserAnswear[id])
            {
                _UserAnswear[id] = false;
            }
            else
            {
                _UserAnswear[id] = true;
            }
        }

        private void EndQuestion(EventArgs e)
        {
            bool a = true; ;
            EventHandler handler = QuestionEnded;
            if (handler != null)
            {

                for (int i = 0; i < 4; i++)
                {
                    if (_UserAnswear[i] != _Answears[i].Correct)
                    {
                        a = false;
                    }
                }
                _isCorrect = a;
                handler(this, e);
            }
        }

    }
}
