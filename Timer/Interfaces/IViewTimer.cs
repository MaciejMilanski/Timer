using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer.Interfaces
{
    public interface IViewTimer
    {
        void mainFormLoad();
        void initializeTimer(int progressBarValue);
        void timerElapsed(object sender, System.Timers.ElapsedEventArgs e);
        bool loadData();
        void reloadTimer();
    }
}
