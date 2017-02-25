using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using UIKit;
using XamarinSample.ViewModels;

namespace XamarinSample.iOS.Views
{
    public partial class MainView : MvxViewController<MainViewModel>
    {
        public MainView() : base("MainView", null)
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var set = this.CreateBindingSet<MainView, MainViewModel>();

            set.Bind(txtTitle).To(vm => vm.Title);

            set.Bind(btnShow).To(x => x.ShowTitleCommand);
            set.Apply();

            // Perform any additional setup after loading the view, typically from a nib.
        }

    }
}