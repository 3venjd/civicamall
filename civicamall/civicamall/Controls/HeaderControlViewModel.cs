using civicamall.Views;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;
using Xamarin.Forms;

namespace civicamall.Controls
{
    public class HeaderControlViewModel
    {
        public ICommand GoBackCommand { get { return new RelayCommand(GoBack); } }

        public ICommand GoToCarCommand { get { return new RelayCommand(GoCar); } }

        public HeaderControlViewModel()
        {

        }

        private async void GoCar()
        {
            var mdp = Application.Current.MainPage as MasterDetailPage;
            await mdp.Detail.Navigation.PushAsync(new ShoppingCarPage());
        }

        private async void GoBack()
        {
            var mdp = Application.Current.MainPage as MasterDetailPage;
            await mdp.Detail.Navigation.PopAsync();
        }
    }
}
