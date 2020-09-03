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
        private readonly IRepository _repository;

        private DateTime groundZero = new DateTime();
        //private DateTime _now = new DateTime(DateTime.Toda)
        private TimeSpan delta = new TimeSpan(0, 0, 0, 0, 0);
        private string dateText;
        private int progressBarValue;

        public ViewTimer()
        {

        }

        ViewTimer(IRepository repository)
        {
            _repository = repository;
        }
        public void mainFormLoad()
        {
            if (loadData())
            {
                initializeTimer(progressBarValue);
            }
            else
                this.Text = "00d:00h:00min:00s:000ms";
        }

        public void initializeTimer(int progressBarValue)
        {
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 10;
            timer.Elapsed += timerElapsed;
            timer.Start();
            this.Maximum = progressBarValue;
        }
        public void timerElapsed(object sender, System.Timers.ElapsedEventArgs e)
        {

            delta = groundZero - DateTime.Now;
            dateText = delta.Days.ToString() + "d:" + delta.Hours.ToString() + "h:" + delta.Minutes.ToString() + "min:" + delta.Seconds.ToString() + "s:" + delta.Milliseconds.ToString() + "ms";

            this.Invoke((MethodInvoker)delegate
            {
                this.Text = dateText;
                this.Value = Convert.ToInt32(delta.TotalSeconds);
                this.Update();
            });
        }
        public bool loadData()
        {
            bool flag = false;
            //Check if file exist, and if the date write in it is not past
            if (_repository.ifExists(_repository.getDate()) && _repository.ifExists(_repository.getPBMaxValue()))
            {             
                if (Convert.ToDateTime(_repository.getDate()) > DateTime.Now)
                {
                    groundZero = Convert.ToDateTime(_repository.getDate());
                    progressBarValue = Convert.ToInt32(_repository.getPBMaxValue());
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
