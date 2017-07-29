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
            Mvx.RegisterType<ICalculation, Calculation>();
            Mvx.RegisterSingleton<IMvxAppStart>(new MvxAppStart<FirstViewModel>());
        }
    }
}
