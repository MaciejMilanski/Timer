using Timer.Models;

namespace Timer
{
    interface IMainForm
    {
        string text { get; set; }
        int value { get; set; }
        int maxValue { get; set; }
        //System.Timers.Timer timer { get; set; }
    }
}
