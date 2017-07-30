using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Test.Core.Services;

namespace Test.Core.ViewModels
{
    public class LoginViewModel : MvxViewModel
    {
        private string userName;
        private string password;

        private readonly IMvxNavigationService _navigationService;
        private IAuthorizationService _authorizationService;
        public LoginViewModel(IMvxNavigationService navigationService, IAuthorizationService authorizationService)
        {
            _navigationService = navigationService;
            _authorizationService = authorizationService;
        }

        public IMvxCommand GoCommand => new MvxCommand(async () => await SingIn());

        public bool CanSignIn => !string.IsNullOrWhiteSpace(Username) && !string.IsNullOrWhiteSpace(Password);
        public string Username
        {
            get { return userName; }
            set
            {
                if (base.SetProperty(ref userName, value))
                    base.RaisePropertyChanged(() => CanSignIn);
            }
        }

        public string Password
        {
            get
            {
                return this.password;
            }
            set
            {
                if (base.SetProperty(ref password, value))
                    base.RaisePropertyChanged(() => CanSignIn);
            }
        }

        private async Task SingIn()
        {
            await _navigationService.Navigate<SecondViewModel, string>(this.Username);
        }
    }
}
