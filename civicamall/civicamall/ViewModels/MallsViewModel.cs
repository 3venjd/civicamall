using civicamall.Models;
using civicamall.Views;
using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace civicamall.ViewModels
{
    public class MallsViewModel : BaseViewModel
    {
        public ObservableCollection<Mall> Malls { get; set; }

        public ObservableCollection<Advertisement> Advertisements { get; set; }

        public Mall MallDetail { get; set; }

        public ICommand GoToMallDetail { get { return new RelayCommand(GoToMallDetails); } }

        public ICommand GoToPromos { get { return new RelayCommand(GoToPromo); } }

        public ICommand GoToStores { get { return new RelayCommand(GoToStore); } }

        public MallsViewModel()
        {
            Malls = new ObservableCollection<Mall>
            {
                new Mall
                {
                    Name = "Mayorca",
                    Image ="Mayorca_logo.png"
                },
                new Mall
                {
                    Name = "Oviedo",
                    Image = "Oviedo_logo.png"
                },
                new Mall
                {
                    Name = "Santa fe",
                    Image = "Santafe_logo.png"

                }
            };

            Advertisements = new ObservableCollection<Advertisement>
            {
                new Advertisement
                {
                    Title = "Promo 1",
                    Image = "promocion_1.jpg"
                },
                new Advertisement
                {
                    Title = "Promo 2",
                    Image = "promocion_2.jpg"
                },
                new Advertisement
                {
                    Title = "Promo 3",
                    Image = "promocion_3.jpg"
                },
                new Advertisement
                {
                    Title = "Promo 4",
                    Image = "promocion_4.jpg"
                },
                new Advertisement
                {
                    Title = "Promo 5",
                    Image = "promocion_5.jpg"
                },
            };

            MallDetail = new Mall
            {
                Name = "Mayorca",
                Image = "Logo_mayorca.png"
            };
        }

        private async void GoToMallDetails()
        {
            var mdp = Application.Current.MainPage as MasterDetailPage;
            await mdp.Detail.Navigation.PushAsync(new MallDetailPage());
        }
        private async void GoToPromo()
        {
            var mdp = Application.Current.MainPage as MasterDetailPage;
            await mdp.Detail.Navigation.PushAsync(new PromosPage());
        }

        private async void GoToStore()
        {
            var mdp = Application.Current.MainPage as MasterDetailPage;
            await mdp.Detail.Navigation.PushAsync(new StorePage());
        }

    }
}
