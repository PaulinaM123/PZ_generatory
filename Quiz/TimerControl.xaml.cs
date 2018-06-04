using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace PZ_generatory.Quiz
{
    public partial class TimerControl : UserControl
    {
<<<<<<< HEAD
<<<<<<< HEAD
        EventHandler CallBack;
=======
>>>>>>> parent of 4c588fb... Merge branch 'master' into Kamil
=======
>>>>>>> parent of 4c588fb... Merge branch 'master' into Kamil
        public TimerControl(int time, EventHandler callBack)
        {
            InitializeComponent();
            timer.Maximum = time;
            Animation.Duration = new Duration(new System.TimeSpan(0, 0, time));

            Animation.Completed += (sender, eArgs) => callBack(sender, eArgs);
        }
    }
}
