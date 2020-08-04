﻿using civicamall.Models;
using civicamall.Views;
using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace civicamall.ViewModels
{
    public class MallsViewModel : BaseViewModel
    {
        public ICommand GoToCarCommand { get { return new RelayCommand(GoCar); } }

        private Color _backgroundColor1;
        private Color _backgroundColor2;

        private Color _textColor1;
        private Color _textColor2;

        private int _selectedIndex;

        public Color BackgroundColor1
        {
            get => _backgroundColor1;
            set
            {
                _backgroundColor1 = value;
                OnPropertyChanged();
            }
        }
        public Color BackgroundColor2
        {
            get => _backgroundColor2;
            set
            {
                _backgroundColor2 = value;
                OnPropertyChanged();
            }
        }
        public Color TextColor1
        {
            get => _textColor1;
            set
            {
                _textColor1 = value;
                OnPropertyChanged();
            }
        }
        public Color TextColor2
        {
            get => _textColor2;
            set
            {
                _textColor2 = value;
                OnPropertyChanged();
            }
        }
        public int ClickIndex
        {
            get => _selectedIndex;
            set
            {
                if (_selectedIndex != value)
                {
                    _selectedIndex = value;
                    OnPropertyChanged();
                }
            }
        }

        public ObservableCollection<Product> Products { get; set; }

        public ObservableCollection<Mall> Malls { get; set; }

        public Mall MallDetail { get; set; }

        public ICommand GoToMallDetail { get { return new RelayCommand(GoToMallDetails); } }

        public ICommand GoToPromos { get { return new RelayCommand(GoToPromo); } }

        public ICommand GoToStores { get { return new RelayCommand(GoToStore); } }

        public ICommand GoToInfoPageCommand { get { return new RelayCommand(GoToInfoPage); } }

        ICommand _tapIndex1Command;
        ICommand _tapIndex2Command;

        public ICommand TapIndex1Command { get => _tapIndex1Command; }
        public ICommand TapIndex2Command { get => _tapIndex2Command; }

        public MallsViewModel()
        {

            LoadData();

            _tapIndex1Command = new Command(TapIndex1);
            _tapIndex2Command = new Command(TapIndex2);

            BackgroundColor1 = Color.FromHex("#F2EDF8");
            TextColor1 = Color.FromHex("#7E2081");

            BackgroundColor2 = Color.FromHex("#7E2081");
            TextColor2 = Color.FromHex("#F2EDF8");

            ClickIndex = 0;

            
        }

        private void LoadData()
        {
            Products = new ObservableCollection<Product>
            {
                new Product
                {
                     Name = "Zapatillas",
                     Image = "zapatillas_1.png",
                     Brand = "Nike",
                     Icon_brand = "ic_nike.jpg",
                     Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry." +
                                   "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s," +
                                   " when an unknown printer took a galley of type and scrambled it to make a type " +
                                   "specimen book. It has survived not only five centuries, but also the leap into " +
                                   "electronic typesetting, remaining essentially unchanged. It was popularised in " +
                                   "the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, " +
                                   "and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                     Base_cost = 50000,
                     Discount = 0,
                     IsFavorite = true,
                     IsDiscount = false

                },
                new Product
                {
                     Name = "Zapatillas",
                     Image = "Zapatillas_2.jpg",
                     Base_cost = 90000,
                     Discount = 0,
                     IsFavorite = false,
                     IsDiscount = false

                },
                new Product
                {
                     Name = "Zapatillas",
                     Image = "Zapatillas_3.jpg",
                     Base_cost = 40000,
                     Discount = 30,
                     IsFavorite = false,
                     IsDiscount = true

                },
                new Product
                {
                     Name = "Zapatillas",
                     Image = "Zapatillas_7.jpg",
                     Base_cost = 90000,
                     Discount = 40,
                     IsFavorite = false,
                     IsDiscount = true

                },
                new Product
                {
                     Name = "Zapatillas",
                     Image = "Zapatillas_5.jpg",
                     Base_cost = 110000,
                     Discount = 20,
                     IsFavorite = true,
                     IsDiscount = true

                },
                new Product
                {
                     Name = "Zapatillas",
                     Image = "Zapatillas_6.jpg",
                     Base_cost = 150000,
                     Discount = 0,
                     IsFavorite = true,
                     IsDiscount = false

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

            MallDetail = new Mall
            {
                Name = "Mayorca",
                Image = "Mayorca_logo.png"
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

        private async void GoToInfoPage()
        {
            var mdp = Application.Current.MainPage as MasterDetailPage;
            await mdp.Detail.Navigation.PushAsync(new InfoBrandPage());
        }

        private async void GoCar()
        {
            var mdp = Application.Current.MainPage as MasterDetailPage;
            await mdp.Detail.Navigation.PushAsync(new ShoppingCarPage());
        }


        void TapIndex1(object sender)
        {

            BackgroundColor1 = Color.FromHex("#F2EDF8");
            TextColor1 = Color.FromHex("#7E2081");

            BackgroundColor2 = Color.FromHex("#7E2081");
            TextColor2 = Color.FromHex("#F2EDF8");

            ClickIndex = 0;
        }

        void TapIndex2(object sender)
        {

            BackgroundColor1 = Color.FromHex("#7E2081");
            TextColor1 = Color.FromHex("#F2EDF8");

            BackgroundColor2 = Color.FromHex("#F2EDF8");
            TextColor2 = Color.FromHex("#7E2081");

            ClickIndex = 1;
        }

    }
}
