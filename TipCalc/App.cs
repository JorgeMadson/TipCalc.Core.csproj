using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using TipCalc.Core.Services;
using TipCalc.Core.ViewModels;

namespace TipCalc.Core
{
    public class App : MvxApplication
    {
        public App()
        {
            Mvx.RegisterType<ICalculation, Calculation>();
            //Registrando que o App vai iniciar com a nossa viewmodel
            Mvx.RegisterSingleton<IMvxAppStart>(new MvxAppStart<TipViewModel>());
            //Ou esse
            //var appStart = new MvxAppStart<TipViewModel>();
            //Mvx.RegisterSingleton<IMvxAppStart>(appStart);
        }
    }

}
