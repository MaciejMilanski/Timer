using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timer.Interfaces;

namespace Timer.Models
{
    public class Settings : System.Windows.Forms.DateTimePicker, ISettings
    {
        private readonly IRepository _repository;

        Settings(IRepository repository)
        {
            _repository = repository;
        }

        public void loadSettingsForm(object sender, EventArgs e)
        {
            loadDPData();            
        }

        public void saveData(DateTime date)
        {
            int maxDPValue = Convert.ToInt32((date - DateTime.Now).TotalSeconds);
            _repository.saveData(Convert.ToString(date), Convert.ToString(maxDPValue));
        }
        public void loadDPData()
        {
            bool flag = false;
            //Check if file exist, and if the date write in it is not past
            if (_repository.ifExists(_repository.getDate()) && Convert.ToDateTime(_repository.getDate()) > DateTime.Now)
            {
                this.Value = Convert.ToDateTime(_repository.getDate());
            }
            else
            {
                this.Value = DateTime.Now;
            }
        }
    }
}
