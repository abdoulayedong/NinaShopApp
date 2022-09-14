using FreshMvvm;
using NinaShopApp.UI.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace NinaShopApp.UI.PageModels
{
    public class OnboardingPageModel : FreshBasePageModel
    {
        public OnboardingPageModel()
        {
            GoToSignupCommand = new Command(
                async () =>
                {
                    await CoreMethods.PushPageModelWithNewNavigation<SigninPageModel>(null);
                });
        }

        public ObservableCollection<OnboardingItem> Items { get; } = new ObservableCollection<OnboardingItem>();

        public override void Init(object initData)
        {
            Items.Add(new OnboardingItem("Welcome to NinaShop, Let's shop", "NinaShopApp.UI.Resources.Images.splash_1.png"));
            Items.Add(new OnboardingItem("We help people connect with store \naround Gabon", "NinaShopApp.UI.Resources.Images.splash_2.png"));
            Items.Add(new OnboardingItem("We show the easy way to shop. \nJust stay at home with us", "NinaShopApp.UI.Resources.Images.splash_3.png"));
        }

        public ICommand GoToSignupCommand { get; }
    }
}
