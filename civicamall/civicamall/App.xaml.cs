using civicamall.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace civicamall
{
    public partial class App : Application
    {
        public static NavigationPage Navigator { get; internal set; }

        public App()
        {
            InitializeComponent();
            bool firts_tiem = false;

            if (firts_tiem)
            {
                MainPage = new OnBoardingPage();
            }
            else
            {
                MainPage = new MasterPage();
            }
            
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
