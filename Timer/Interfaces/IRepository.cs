
namespace Timer
{
    interface IRepository
    {
        string getDate();
        string getPBMaxValue();
        bool ifExists(string fileLine);
        void saveData(string date, string maxValue);
    }
}
