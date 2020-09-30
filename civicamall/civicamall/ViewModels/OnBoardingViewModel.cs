using civicamall.Views;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace civicamall.ViewModels
{
    public class OnBoardingViewModel : BaseViewModel
    {
        public ICommand GoToLoginCommand { get { return new RelayCommand(GoToLogin); } }

        public OnBoardingViewModel()
        {

        }

        private async void GoToLogin()
        {
            Application.Current.MainPage = new NavigationPage(new LoginPage());
            await Application.Current.MainPage.Navigation.PushAsync(new LoginPage());
        }
    }
}
