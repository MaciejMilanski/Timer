using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timer.Models;
using Timer.DTOs;

namespace Timer.Presenter
{ 
    class MainFormPresenter
    {
        ViewTimer _viewTimer = new ViewTimer();
        SavedData savedData = new SavedData();

        private readonly IManageMainForm _manageMainForm;

        private DateTime groundZero = new DateTime();
        //private DateTime _now = new DateTime(DateTime.Toda)
        private TimeSpan delta = new TimeSpan(0, 0, 0, 0, 0);       
        private string dateText;
        private string[] file;
        private int progressBarValue;

        MainFormPresenter(IManageMainForm manageMainForm) 
        {
            _manageMainForm = manageMainForm;
        }
        private void mainFormLoad(object sender, EventArgs e)
        {
            if (loadSavedData())
            {
                initializeTimer(progressBarValue);
            }
            else
                _viewTimer.Text = "00d:00h:00min:00s:000ms";        
        }
        void initializeTimer(int progressBarValue)
        {
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 10;
            timer.Elapsed += timerElapsed;
            timer.Start();
            _viewTimer.Maximum = progressBarValue;
        }
        private void timerElapsed(object sender, System.Timers.ElapsedEventArgs e)
        {

            delta = groundZero - DateTime.Now;
            dateText = delta.Days.ToString() + "d:" + delta.Hours.ToString() + "h:" + delta.Minutes.ToString() + "min:" + delta.Seconds.ToString() + "s:" + delta.Milliseconds.ToString() + "ms";

            _viewTimer.Invoke((MethodInvoker)delegate
            {
                _viewTimer.Text = dateText;
               // _viewTimer.Value = Convert.ToInt32(delta.TotalSeconds);
                _viewTimer.Update();
            });
        }
        private bool loadSavedData()
        {
            bool flag = false;
            //Check if file exist, and if the date write in it is not past
            if (!System.IO.File.Exists(Environment.CurrentDirectory.ToString() + "save.txt"))
            {
                file = System.IO.File.ReadAllLines(Environment.CurrentDirectory.ToString() + "save.txt");
                if (Convert.ToDateTime(file[0]) > DateTime.Now)
                {
                    groundZero = Convert.ToDateTime(file[0]);
                    progressBarValue = Convert.ToInt32(file[1]);
                    flag = true;
                }
            }
            return flag;
        }
    }
}
