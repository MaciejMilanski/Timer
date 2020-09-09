
namespace Timer.Interfaces
{
    public interface IViewTimer
    {
        string mainFormLoadText();
        int mainFormLoadMaxValue();
        int mainFormLoadValue();
        System.Timers.Timer initializeTimer();
        void timerElapsed(object sender, System.Timers.ElapsedEventArgs e);
        bool loadData();
        void reloadTimer();
    }
}
