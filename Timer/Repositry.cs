using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
    class Repository : IRepository
    {
        public bool ifExists(string fileLine)
        {
            if (fileLine.FirstOrDefault().ToString().Length > 0)
                return true;
            else
                return false;
        }

        public string getDate()
        {
            string[] file;
            if (System.IO.File.Exists(Environment.CurrentDirectory.ToString() + "/save.txt"))
            {
                file = System.IO.File.ReadAllLines(Environment.CurrentDirectory.ToString() + "/save.txt");
                return file[0];
            }
            else
                return "00:00:00";
        }

        public string getPBMaxValue()
        {
            string[] file;
            if (System.IO.File.Exists(Environment.CurrentDirectory.ToString() + "/save.txt"))
            {
                file = System.IO.File.ReadAllLines(Environment.CurrentDirectory.ToString() + "/save.txt");
                return file[1];
            }
            else
                return "0";
        }
        public void saveData(string date, string maxValue)
        {
            string[] file = {"",""};
            file[0] = date;
            file[1] = maxValue;

            System.IO.File.WriteAllLines(Environment.CurrentDirectory.ToString() + "/save.txt", file);
        }
    }
}
