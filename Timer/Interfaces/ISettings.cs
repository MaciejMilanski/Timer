using System;

namespace Timer.Interfaces
{
    public interface ISettings
    {
        void loadSettingsForm(object sender, EventArgs e);
        void saveData(DateTime date);
        DateTime loadDPData();       
    }
}
