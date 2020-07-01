using civicamall.Models;
using civicamall.ViewModels;
using civicamall.Views;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace civicamall.Controls
{
    public class HeaderControlViewModel: BaseViewModel
    {
        public ObservableCollection<Advertisement> Advertisements { get; set; }
        public ICommand GoBackCommand { get { return new RelayCommand(GoBack); } }

        public ICommand GoToCarCommand { get { return new RelayCommand(GoCar); } }

        private int _position;

        public int Position
        {
            get => _position;
            set
            {
                _position = value;
                OnPropertyChanged();
            }
        }

        public HeaderControlViewModel()
        {
            LoadData();
            Slider();
        }

        private void LoadData()
        {
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
        private void Slider()
        {
            Device.StartTimer(TimeSpan.FromSeconds(5), (Func<bool>)(() =>
            {
                Position = (Position + 1) % Advertisements.Count;
                return true;
            }));

        }
    }
}
