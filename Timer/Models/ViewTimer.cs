using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timer.Interfaces;
using System.Timers;

namespace Timer.Models
{
    public class ViewTimer : CircularProgressBar.CircularProgressBar, IViewTimer
    {
        Repository _repository = new Repository();

        System.Timers.Timer timer;
        private DateTime groundZero = new DateTime();
        private TimeSpan delta = new TimeSpan(0, 0, 0, 0, 0);
        private string dateText;
        private int progressBarMaxValue;
        private int progressBarValue;
        private bool flag = false;

        public ViewTimer()
        {           
        }
        public string mainFormLoadText()
        {
            if (flag)
            {
                return dateText;
            }
            else
                return "00d:00h:00min:00s:000ms";
        }
        public int mainFormLoadMaxValue()
        {
            if (flag)
            {
                return progressBarMaxValue;
            }
            else
                return 100;
        }
        public int mainFormLoadValue()
        {
            if (flag)
            {
                return progressBarValue;
            }
            else
                return 100;
        }

        public System.Timers.Timer initializeTimer()
        {
            timer = new System.Timers.Timer();
            timer.Interval = 10;
            timer.Elapsed += timerElapsed;
            timer.Start();
            loadData();

            return timer;
        }
        public void timerElapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (flag)
            {
                delta = groundZero - DateTime.Now;
                dateText = delta.Days.ToString() + "d:" + delta.Hours.ToString() + "h:" + delta.Minutes.ToString() + "min:" + delta.Seconds.ToString() + "s:" + delta.Milliseconds.ToString() + "ms";
                progressBarValue = Convert.ToInt32(delta.TotalSeconds);
            }
            if (delta.TotalSeconds < 0)
            {
                dateText = "00d:00h:00min:00s:000ms";
                progressBarValue = 0;
                timer.Stop();
                timer.Close();
            }
        }
        public bool loadData()
        {            
            //Check if file exist, and if the date write in it is not past
            if (_repository.ifExists(_repository.getDate()) && _repository.ifExists(_repository.getPBMaxValue()))
            {             
                if (Convert.ToDateTime(_repository.getDate()) > DateTime.Now)
                {
                    groundZero = Convert.ToDateTime(_repository.getDate());
                    delta = groundZero - DateTime.Now;
                    dateText = delta.Days.ToString() + "d:" + delta.Hours.ToString() + "h:" + delta.Minutes.ToString() + "min:" + delta.Seconds.ToString() + "s:" + delta.Milliseconds.ToString() + "ms";
                    progressBarMaxValue = Convert.ToInt32(_repository.getPBMaxValue());
                    progressBarValue = Convert.ToInt32(delta.TotalSeconds);
                    flag = true;
                }
            }
            return flag;
        }
        public void reloadTimer()
        {
            groundZero = Convert.ToDateTime(_repository.getDate());
            progressBarValue = Convert.ToInt32(_repository.getPBMaxValue());
        }
    }
}
