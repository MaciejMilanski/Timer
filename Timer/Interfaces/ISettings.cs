using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer.Interfaces
{
    public interface ISettings
    {
        void loadSettingsForm(object sender, EventArgs e);
        void saveData(DateTime date);
        DateTime loadDPData();       
    }
}
