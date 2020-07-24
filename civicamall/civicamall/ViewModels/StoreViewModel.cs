using civicamall.Models;
using civicamall.Views;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xam.TabView;
using Xam.TabView.Control;
using Xamarin.Forms;

namespace civicamall.ViewModels
{
    public class StoreViewModel : BaseViewModel
    {
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


        public ObservableCollection<Brand> Brands { get; set; }

        public Brand BranDetail { get; set; }

        public ObservableCollection<ShoppingCar> ShopInCar { get; set; }

        public ObservableCollection<Product> Products { get; set; }

        public ICommand GoToBrand { get { return new RelayCommand(GoToProductBrand); } }

        ICommand _tapIndex1Command;
        ICommand _tapIndex2Command;

        public ICommand TapIndex1Command  { get => _tapIndex1Command;}
        public ICommand TapIndex2Command { get => _tapIndex2Command; }
        

        public StoreViewModel()
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
                     Image = "zapatillas_1",
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
                     Image = "zapatillas_2",
                     Base_cost = 90000,
                     Discount = 0,
                     IsFavorite = false,
                     IsDiscount = false

                },
                new Product
                {
                     Name = "Zapatillas",
                     Image = "zapatillas_3",
                     Base_cost = 40000,
                     Discount = 30,
                     IsFavorite = false,
                     IsDiscount = true

                },
                new Product
                {
                     Name = "Zapatillas",
                     Image = "zapatillas_4",
                     Base_cost = 90000,
                     Discount = 40,
                     IsFavorite = false,
                     IsDiscount = true

                },
                new Product
                {
                     Name = "Zapatillas",
                     Image = "zapatillas_5",
                     Base_cost = 110000,
                     Discount = 20,
                     IsFavorite = true,
                     IsDiscount = true

                },
                new Product
                {
                     Name = "Zapatillas",
                     Image = "zapatillas_6",
                     Base_cost = 150000,
                     Discount = 0,
                     IsFavorite = true,
                     IsDiscount = false

                },

            };

            Brands = new ObservableCollection<Brand>
            {
                new Brand
                {
                     Name = "ADIDAS",
                     Image = "Adidas_logo.png",
                     Close_Day = "Viernes",
                     CLose_hour = "7:00 PM",
                     Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum",
                     HolyDay_open = false,
                     IsOpen = true,
                     IsClose = false,
                     Open_Day = "Lunes",
                     Open_Hour = "9:00 AM",
                     Saturday_Open = true,
                     Url_Facebook = "www.facebook.com",
                     Url_Instagram = "www.instagram.com",
                     Url_Twitter = "www.twitter.com",
                     Url_Web = "www.adidas.com",
                     Url_Youtube = "www.youtube.com"
                },
                new Brand
                {
                     Name = "RIFLE",
                     Image = "Rifle_logo.png",
                     IsOpen = false,
                     IsClose = false,
                     Open_Hour = "7:00 AM",
                },
                new Brand
                {
                     Name = "AMERICANINO",
                     Image = "Americanino_logo.png",
                     IsOpen = false,
                     IsClose = true,
                     Open_Hour = "8:30 AM",
                },
                new Brand
                {
                     Name = "NIKE",
                     Image = "Nike_logo.jpg",
                     IsOpen = false,
                     IsClose = true,
                     Open_Hour = "8:30 AM",
                },
            };

            BranDetail = new Brand
            {
                Name = "ADIDAS",
                Image = "Adidas_logo.png",
                Close_Day = "Viernes",
                CLose_hour = "7:00 PM",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum",
                HolyDay_open = false,
                IsOpen = true,
                IsClose = false,
                Open_Day = "Lunes",
                Open_Hour = "9:00 AM",
                Saturday_Open = true,
                Url_Facebook = "www.facebook.com",
                Url_Instagram = "www.instagram.com",
                Url_Twitter = "www.twitter.com",
                Url_Web = "www.adidas.com",
                Url_Youtube = "www.youtube.com"
            };

            ShopInCar = new ObservableCollection<ShoppingCar>
            {
                new ShoppingCar
                {
                     Name = "Camiseta",
                     Image = "camiseta_1.jpg",
                     Base_cost = 50000,
                     Discount = 0,
                     IsDiscount = false

                },
                new ShoppingCar
                {
                     Name = "Gorra",
                     Image = "gorra_1.jpg",
                     Base_cost = 90000,
                     Discount = 0,
                     IsDiscount = false

                },
                new ShoppingCar
                {
                     Name = "Pantalon",
                     Image = "pantalon_1.jpg",
                     Base_cost = 40000,
                     Discount = 30,
                     IsDiscount = true

                },
                new ShoppingCar
                {
                     Name = "Vestido",
                     Image = "Vestido_1_1.jpg",
                     Base_cost = 90000,
                     Discount = 40,
                     IsDiscount = true

                },
                new ShoppingCar
                {
                     Name = "Zapatillas",
                     Image = "zapatillas_1.png",
                     Base_cost = 110000,
                     Discount = 20,
                     IsDiscount = true

                },
            };
        }

        private async void GoToProductBrand()
        {
            var mdp = Application.Current.MainPage as MasterDetailPage;
            await mdp.Detail.Navigation.PushAsync(new TabbedBrandPage());
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
