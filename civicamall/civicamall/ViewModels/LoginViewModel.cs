using civicamall.Views;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace civicamall.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public ICommand GoToIndexCommand { get { return new RelayCommand(GoToIndex); } }

        public LoginViewModel()
        {

        }
        private async void GoToIndex()
        {

            Application.Current.MainPage = new NavigationPage(new MasterPage());
            await Application.Current.MainPage.Navigation.PushAsync( new MasterPage());
        }
    }
}
