using Android.Animation;
using Android.App;
using Android.Content;
using Android.OS;
using Com.Airbnb.Lottie;

namespace NinaShopApp.UI.Droid
{
    [Activity(Label = "SplashActivity",
        Theme = "@style/MainTheme.Splash",
        MainLauncher = true,
        NoHistory = true,
        Icon = "@mipmap/icon")]
    public class SplashActivity : Activity, Animator.IAnimatorListener
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Activity_Splash);

            var animationView = FindViewById<LottieAnimationView>(Resource.Id.animation_view);
            animationView.AddAnimatorListener(this);
        }

        public void OnAnimationEnd(Animator animation)
        {
            StartActivity(new Intent(Application.Context, typeof(MainActivity)));
        }

        public void OnAnimationRepeat(Animator animation) { }
        public void OnAnimationCancel(Animator animation) { }
        public void OnAnimationStart(Animator animation) { }
    }
}