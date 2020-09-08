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

namespace Timer
{
    public partial class SettingsForm : Form, ISettingsForm
    {
        SettingsFormPresenter presenter;
        public SettingsForm()
        {
            InitializeComponent();
        }
        private void SettingsForm_Load(object sender, EventArgs e)
        {
            presenter = new SettingsFormPresenter(this);
            presenter.formLoad();
        }

        private void tbbReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (presenter.validate())
            {
                presenter.saveData();
                Close();
            }
            else
                MessageBox.Show("Cannot set earlier date or equal present date", "Error", 0);
        }

        private void tbbQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public DateTime date { get => dtpDate.Value; set => dtpDate.Value = value; }
    }
}
