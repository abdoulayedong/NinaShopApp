using FreshMvvm;
using NinaShopApp.UI.PageModels;
using Xamarin.Forms;

namespace NinaShopApp.UI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            LoadBasicNav();
        }

        public void LoadBasicNav()
        {
            Page onboardingPage = FreshPageModelResolver.ResolvePageModel<OnboardingPageModel>();
            FreshNavigationContainer basicNavigation = new FreshNavigationContainer(onboardingPage);
            MainPage = basicNavigation;
        }
    }
}
