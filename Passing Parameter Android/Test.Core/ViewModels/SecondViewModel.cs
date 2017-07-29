using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Core.ViewModels
{
    public class SecondViewModel : MvxViewModel<string>
    {
        private string name;

        public string Name
        {
            get { return name; }
            set {
                name = value;
                base.RaisePropertyChanged(() => Name);
            }
        }

        public override Task Initialize(string userData)
        {
            Name = userData;
            return Task.FromResult(true);
        }
    }
}
