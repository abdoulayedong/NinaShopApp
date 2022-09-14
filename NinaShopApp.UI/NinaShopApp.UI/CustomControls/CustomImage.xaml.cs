using System;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NinaShopApp.UI.CustomControls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomImage : ContentView
    {
        public CustomImage()
        {
            InitializeComponent();
        }


        public string ImageSource
        {
            get => (string)GetValue(ImageSourceProperty);
            set => SetValue(ImageSourceProperty, value);
        }

        public static readonly BindableProperty ImageSourceProperty =
            BindableProperty.Create(
                declaringType: typeof(CustomImage),
                propertyName: nameof(ImageSource),
                returnType: typeof(string),
                defaultValue: String.Empty,
                defaultBindingMode: BindingMode.OneWay,
                propertyChanged: ImageSourceChanged);

        private static void ImageSourceChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable == null)
            {
                return;
            }
            CustomImage currentImage = (CustomImage)bindable;
            var source = newValue.ToString();
            currentImage.MyImage.Source = Xamarin.Forms.ImageSource.FromResource(source, typeof(CustomImage).GetTypeInfo().Assembly);
        }
    }
}