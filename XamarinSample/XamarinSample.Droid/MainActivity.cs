using Android.App;
using Android.Content.PM;
using Android.OS;
using MvvmCross.Droid.Views;
using XamarinSample.ViewModels;

namespace XamarinSample.Droid
{
    [Activity(Label = "XamarinSample", Icon = "@drawable/icon",
        Theme = "@style/MainTheme",
        MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : MvxActivity<MainViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.MainPage);
        }
    }
}