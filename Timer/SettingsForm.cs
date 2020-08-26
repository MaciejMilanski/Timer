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
    public partial class SettingsForm : Form
    {  
        public SettingsForm()
        {
            InitializeComponent();
            if (System.IO.File.Exists("C:/Moje/GitHub Repository/Timer/save.txt"))
                dtpDate.Value = Convert.ToDateTime(System.IO.File.ReadAllText("C:/Moje/GitHub Repository/Timer/save.txt"));
        }
        private void SaveData(DateTime dataPickerValue)
        {
            TextWriter txt = new StreamWriter("C:/Moje/GitHub Repository/Timer/save.txt");
            TimeSpan delta = dtpDate.Value - DateTime.Now;

            txt.WriteLine(dtpDate.Value.ToString());
            txt.WriteLine(Convert.ToInt32(delta.TotalSeconds));
            txt.Close();
        }
        private void TBBReturn_Click(object sender, EventArgs e)
        {
            Close();    
        }
        private void TBBQuit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();    
        }

        private void bSave_Click(object sender, EventArgs e)
        {     
            SaveData(dtpDate.Value);           
            Close();
        }
    }
}
