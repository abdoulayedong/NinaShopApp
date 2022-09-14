using System;
using System.Collections.Generic;
using System.Text;

namespace NinaShopApp.UI.Models
{
    public struct OnboardingItem
    {
        public OnboardingItem(string message, string imageSource)
        {
            Message = message;
            ImageSource = imageSource;
        }
        public string Message { get; set; }
        public string ImageSource { get; set; }
    }
}
