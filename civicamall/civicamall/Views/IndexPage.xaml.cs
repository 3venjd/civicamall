using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace civicamall.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IndexPage : ContentPage
    {
        public IndexPage()
        {
            InitializeComponent();
            Device.StartTimer(TimeSpan.FromSeconds(5), (Func<bool>)(() =>
            {
                MainCarouselView.Position = (MainCarouselView.Position + 1) % 5;
                return true;
            }));
        }
    }
}