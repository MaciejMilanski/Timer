using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timer.Models;

namespace Timer.Presenter
{
    class SettingsFormPresenter
    {
        private readonly ISettingsForm _view;

        Settings _settings = new Settings();
        public SettingsFormPresenter(ISettingsForm view)
        {
            _view = view;
        }

        public void formLoad()
        {
            _view.date = _settings.loadDPData();
        }
        public void saveData()
        {
            _settings.saveData(_view.date);
        }
        public bool validate()
        {
            if (_settings.validateDate(_view.date))
                return true;
            else
                return false;
        }
    }
}
