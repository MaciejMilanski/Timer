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
using Timer.Presenter;

namespace Timer
{
    public partial class MainForm : Form, IMainForm
    {
        Models.ViewTimer _viewTimer;

        private MainFormPresenter presenter;
        public MainForm()
        {
            InitializeComponent();
        }

        public Models.ViewTimer ViewTimer
        {
            get
            {
                _viewTimer.Text = pbProgressBar.Text;
                _viewTimer.Minimum = pbProgressBar.Minimum;
                _viewTimer.Maximum = pbProgressBar.Maximum;
                _viewTimer.Value = pbProgressBar.Value;

                return _viewTimer;
            }
            set
            {
                _viewTimer = value;

                pbProgressBar.Text = _viewTimer.Text;
                pbProgressBar.Minimum = _viewTimer.Minimum;
                pbProgressBar.Maximum = _viewTimer.Maximum;
                pbProgressBar.Value = _viewTimer.Value;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            presenter = new MainFormPresenter(this);
            presenter.formLoad();
        }
    }
}
