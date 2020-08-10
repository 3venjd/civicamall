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

        private ObservableCollection<Product> _products;
        public ObservableCollection<Product> Products
        {
            get => _products;
            set 
            {
                _products = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<Mall> Malls { get; set; }

        public ICommand GoBackCommand { get { return new RelayCommand(GoBack); } }

        public ICommand GoToCarCommand { get { return new RelayCommand(GoCar); } }

        public ICommand GoNotFoundCommand { get { return new RelayCommand(GoNotFound); } }

        private int _position;

        private double _opacity;

        public double Opacity
        {
            get => _opacity;
            set
            {
                _opacity = value;
                OnPropertyChanged();
            }
        }

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

        }

        private async void GoCar()
        {
            var mdp = Application.Current.MainPage as MasterDetailPage;
            await mdp.Detail.Navigation.PushAsync(new ShoppingCarPage());
        }
        
        private async void GoNotFound()
        {
            var mdp = Application.Current.MainPage as MasterDetailPage;
            await mdp.Detail.Navigation.PushAsync(new NotFoundPage());
        }

        

        private async void GoBack()
        {
            var mdp = Application.Current.MainPage as MasterDetailPage;
            await mdp.Detail.Navigation.PopAsync();
        }
        private void Slider()
        {
           /* Device.StartTimer(TimeSpan.FromSeconds(1), (Func<bool>)(() =>
            {
                Opacity = Opacity - 0.2;
                return true;
            }));*/
            Device.StartTimer(TimeSpan.FromSeconds(5), (Func<bool>)(() =>
            {
                Position = (Position + 1) % Advertisements.Count;
                Opacity = 1;
                return true;
            }));
        }
    }
}
