using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Platform;
using MvvmCross.iOS.Views.Presenters;
using UIKit;

namespace XamarinSample.iOS
{
    public class Setup : MvxIosSetup
    {

        protected override IMvxApplication CreateApp()
        {
            return new App();
        }

        public Setup(IMvxApplicationDelegate applicationDelegate, UIWindow window) : base(applicationDelegate, window)
        {
        }

        public Setup(IMvxApplicationDelegate applicationDelegate, IMvxIosViewPresenter presenter) : base(applicationDelegate, presenter)
        {
        }
    }
}