using Caliburn.Micro;
using CaliburnMicroTraining01.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CaliburnMicroTraining01
{
    public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            //base.OnStartup(sender, e);
            DisplayRootViewFor<_02ShellViewModel>();
        }
    }
}
