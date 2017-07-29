using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Test.Core.ViewModels
{
    public class FirstViewModel : MvxViewModel
    {
        public ICommand GoCommand
        {
            get
            {
                return new MvxCommand(() => ShowViewModel<SecondViewModel>());
            }
        }
    }



}
