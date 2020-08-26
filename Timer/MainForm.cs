using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class MainForm : Form
    {
        private DateTime groundZero = new DateTime();
        //private DateTime _now = new DateTime(DateTime.Toda)
        private TimeSpan delta = new TimeSpan(0, 0, 0, 0, 0);
        private string monthsDays;
        private string hourSeconds;
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            if (loadSavedData())
            {
                initTimer();
                loadProgressBar(groundZero);
            }
            else
                pbProgressBar.Text = "00d:00h:00min:00s:000ms";
        }
        private void initTimer()
        {
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 10;
            timer.Elapsed += timerElapsed;
            timer.Start();
        }
        private void loadProgressBar(DateTime groundZero)
        {
            delta = groundZero - DateTime.Now;
            pbProgressBar.Minimum = 0;
            pbProgressBar.Maximum = Convert.ToInt32(delta.TotalSeconds);
            pbProgressBar.Value = Convert.ToInt32(0.6 * delta.TotalSeconds);
            pbProgressBar.Update();
        }
        private bool loadSavedData()
        {
            if (!System.IO.File.Exists(@"C:/Moje/GitHub Repository/Timer/save.txt") || Convert.ToDateTime(System.IO.File.ReadAllText(@"C:/Moje/GitHub Repository/Timer/save.txt")) < DateTime.Now)
                return false;
            else
            {
                groundZero = Convert.ToDateTime(System.IO.File.ReadAllText(@"C:/Moje/GitHub Repository/Timer/save.txt"));
                return true;
            }               

        }
        private void reloadSavedData()
        {
            groundZero = Convert.ToDateTime(System.IO.File.ReadAllText(@"C:/Moje/GitHub Repository/Timer/save.txt"));
        }
        private void timerElapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            
            delta = groundZero - DateTime.Now;
            monthsDays = delta.Days.ToString();
            hourSeconds = delta.Days.ToString() + "d:" + delta.Hours.ToString() + "h:" + delta.Minutes.ToString() + "min:" + delta.Seconds.ToString() + "s:" + delta.Milliseconds.ToString() + "ms";

            pbProgressBar.Invoke((MethodInvoker)delegate
            {
                pbProgressBar.Text = hourSeconds;
                pbProgressBar.Value = Convert.ToInt32(delta.TotalSeconds);
                pbProgressBar.Update();
            });
        }        
        private void tbbQuit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void tbbSettings_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            loadSavedData();
            settingsForm.ShowDialog();
            reloadSavedData();

        }
    }
}
