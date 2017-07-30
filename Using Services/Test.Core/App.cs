using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Core.Services;
using Test.Core.ViewModels;

namespace Test.Core
{
    public class App : MvxApplication
    {
        public App()
        {

        }

        public override void Initialize()
        {
            Mvx.RegisterType<IAuthorizationService, AuthorizationService>();

            // forcing is logged to false
            Mvx.Resolve<IAuthorizationService>().IsLogged = false;

            if (Mvx.Resolve<IAuthorizationService>().IsLogged)
            {
                this.RegisterNavigationServiceAppStart<SecondViewModel>();
            }
            else
            {
                this.RegisterNavigationServiceAppStart<LoginViewModel>();

            }
        }
    }
}
