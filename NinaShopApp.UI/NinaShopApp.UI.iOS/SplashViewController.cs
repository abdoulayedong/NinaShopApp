using Airbnb.Lottie;
using UIKit;

namespace NinaShopApp.UI.iOS
{
    public class SplashViewController : UIViewController
    {
        public SplashViewController() : base() { }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var viewAnimation = LOTAnimationView.AnimationNamed("shopping");
            viewAnimation.ContentMode = UIViewContentMode.Center;

            View.AddSubview(viewAnimation);
            View.BackgroundColor = UIColor.White;

            viewAnimation.Center = View.Center;

            viewAnimation.PlayWithCompletion((finished) =>
            {
                UIApplication.SharedApplication.Delegate.FinishedLaunching
                (UIApplication.SharedApplication, new Foundation.NSDictionary());
            });
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
        }
    }
}