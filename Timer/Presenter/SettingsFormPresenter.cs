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
        SettingsFormPresenter(ISettingsForm view)
        {
            _view = view;
        }
        void formLoad()
        {
            _view.Settings = _settings;
        }
    }
}
