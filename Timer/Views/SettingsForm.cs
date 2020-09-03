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

namespace Timer
{
    public partial class SettingsForm : Form, ISettingsForm
    {
        Models.Settings _settings;
        public SettingsForm()
        {
            InitializeComponent();
        }

        public Settings Settings
        {
            get
            {
                _settings.Value = dtpDate.Value;

                return _settings;
            }
            set
            {
                _settings = value;

                dtpDate.Value = _settings.Value;
            }

        }
    }
}
