using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
