using MvvmCross.Core.Navigation;
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
        private string name;

        private readonly IMvxNavigationService _navigationService;
        public FirstViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public IMvxCommand GoCommand => new MvxCommand(async () => await RealCommand());
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                base.RaisePropertyChanged(() => Name);
            }
        }

        private async Task RealCommand()
        {
            await _navigationService.Navigate<SecondViewModel, string>(this.Name);
        }
    }
}
