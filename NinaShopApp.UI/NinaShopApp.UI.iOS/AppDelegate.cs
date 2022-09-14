using Foundation;
using Lottie.Forms.Platforms.Ios;
using UIKit;

namespace NinaShopApp.UI.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            if (Window == null)
            {
                Window = new UIWindow(frame: UIScreen.MainScreen.Bounds);
                var initialViewControler = new SplashViewController();
                Window.RootViewController = initialViewControler;
                Window.MakeKeyAndVisible();

                return true;
            }
            else
            {
                global::Xamarin.Forms.Forms.Init();
                AnimationViewRenderer animationView = new AnimationViewRenderer();
                animationView.Init();  
                LoadApplication(new App());

                return base.FinishedLaunching(app, options);
            }
        }
    }
}
