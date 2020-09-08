using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timer.Models;
using Timer.Interfaces;

namespace Timer.Presenter
{ 
    class MainFormPresenter
    {
        private readonly IMainForm _view;
        ViewTimer _viewTimer = new ViewTimer();

       public  MainFormPresenter(IMainForm view)
        {
            _view = view;           
        }

        public void formLoad()
        {
            _viewTimer.initializeTimer();
            _view.text = _viewTimer.mainFormLoadText();
            _view.maxValue = _viewTimer.mainFormLoadMaxValue();
            _view.value = _viewTimer.mainFormLoadValue();      
        }
        public void reloadTimer()
        {
            _view.text = _viewTimer.mainFormLoadText();
            _view.maxValue = _viewTimer.mainFormLoadMaxValue();
            _view.value = _viewTimer.mainFormLoadValue();
        }
    }
}
