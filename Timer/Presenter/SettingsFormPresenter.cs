using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer.Presenter
{
    class SettingsFormPresenter
    {
        private readonly ISettingsForm _SettingsForm;
        SettingsFormPresenter(ISettingsForm SettingsForm, DateTime datePickerValue)
        {
            _SettingsForm = SettingsForm;
        }
    }
}
