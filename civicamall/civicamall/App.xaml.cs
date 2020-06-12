using civicamall.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace civicamall
{
    public partial class App : Application
    {
        public static object Navigator { get; internal set; }

        public App()
        {
            InitializeComponent();

            MainPage = new MasterPage();
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
