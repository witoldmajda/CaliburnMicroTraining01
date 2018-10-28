using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CaliburnMicroTraining01.ViewModels
{
    //public class ShellViewModel : PropertyChangedBase
    public class ShellViewModel : Conductor<object>
    {
        private string _name;

        public ShellViewModel()
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

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                NotifyOfPropertyChange(() => Name);
                NotifyOfPropertyChange(() => CanSayHello);
            }
        }

        public bool CanSayHello
        {
            get
            {
                return !string.IsNullOrWhiteSpace(Name);
            }            
        }

        public void SayHello()
        {
            MessageBox.Show(string.Format("Hello {0}!", Name));
        }


    }
}
