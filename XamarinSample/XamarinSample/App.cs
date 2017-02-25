using Acr.UserDialogs;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using MvvmCross.Platform.IoC;
using XamarinSample.ViewModels;

namespace XamarinSample
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            base.Initialize();

            // 注册所有的服务类
            CreatableTypes().EndingWith("Service").AsInterfaces().RegisterAsLazySingleton();
            Mvx.RegisterSingleton(UserDialogs.Instance);
            RegisterAppStart<MainViewModel>();
        }
    }
}
