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
using Timer.Models;
using Timer.Presenter;
using Timer.Interfaces;

namespace Timer
{
    public partial class MainForm : Form, IMainForm
    {
       
        private System.Timers.Timer timer = new System.Timers.Timer();
        MainFormPresenter presenter;
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            presenter = new MainFormPresenter(this);
            presenter.formLoad();
            timer.Interval = 10;
            timer.Elapsed += timerElapsed;
            timer.Start();
       

        }
        private void TBBSettings_Click(object sender, EventArgs e)
        {
            SettingsForm settings = new SettingsForm();
            //presenter = new MainFormPresenter(this);
            settings.ShowDialog();
            presenter.formLoad();

        }
        private void TBBQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void timerElapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            //presenter = new MainFormPresenter(this);
            this.Invoke((MethodInvoker)delegate
           {
               presenter.reloadTimer();
           });
        }

        public string text { get => pbProgressBar.Text; set => pbProgressBar.Text = value; }
        public int value { get => pbProgressBar.Value; set => pbProgressBar.Value = value; }
        public int maxValue { get => pbProgressBar.Maximum; set => pbProgressBar.Maximum = value; }
        //public System.Timers.Timer timer { get => _timer; set => _timer = value; }
    }
}
