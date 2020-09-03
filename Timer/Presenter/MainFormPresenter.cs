using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timer.Models;

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
            _view.ViewTimer = _viewTimer;
        }
    }
}
