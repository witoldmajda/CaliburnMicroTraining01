using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaliburnMicroTraining01.ViewModels
{
    public class _02ShellViewModel : Conductor<object>
    {
        public _02ShellViewModel()
        {
            ShowPageOne();
            ShowPageTwo();
        }

        public void ShowPageOne()
        {
            ActivateItem(new PageOneViewModel());
        }

        public void ShowPageTwo()
        {
            ActivateItem(new PageTwoViewModel());
        }
    }
}
