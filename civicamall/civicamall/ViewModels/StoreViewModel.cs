using civicamall.Models;
using civicamall.Views;
using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using System.Windows.Input;
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
            get { return this._backgroundColor1; }
            set { this.SetValue(ref this._backgroundColor1, value); }
        }
        public Color BackgroundColor2
        {
            get { return this._backgroundColor2; }
            set { this.SetValue(ref this._backgroundColor2, value); }
        }
        public Color TextColor1
        {
            get { return this._textColor1; }
            set { this.SetValue(ref this._textColor1, value); }
        }
        public Color TextColor2
        {
            get { return this._textColor2; }
            set { this.SetValue(ref this._textColor2, value); }
        }
        public int ClickIndex
        {
            get { return this._selectedIndex; }
            set { this.SetValue(ref this._selectedIndex, value); }
        }



        private ObservableCollection<Brand> brands;

        public ObservableCollection<Brand> Brands
        {
            get { return this.brands; }
            set { this.SetValue(ref this.brands, value); }
        }

        private Brand branDetail;
        public Brand BranDetail
        {
            get { return this.branDetail; }
            set { this.SetValue(ref this.branDetail, value); }
        }

        private ObservableCollection<ShoppingCar> shopInCar;
        public ObservableCollection<ShoppingCar> ShopInCar
        {
            get { return this.shopInCar; }
            set { this.SetValue(ref this.shopInCar, value); }
        }

        private ObservableCollection<Product> products;
        public ObservableCollection<Product> Products
        {
            get { return this.products; }
            set { this.SetValue(ref this.products, value); }
        }

        public ICommand GoToBrand { get { return new RelayCommand(GoToProductBrand); } }

        public ICommand GoToInfoPageCommand { get { return new RelayCommand(GoToInfoPage); } }

        ICommand _tapIndex1Command;
        ICommand _tapIndex2Command;

        public ICommand TapIndex1Command { get => _tapIndex1Command; }
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
                     Name = "Camiseta con degradados azul a blanco con botones blancos",
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
            await App.Navigator.PushAsync(new TabbedBrandPage());
        }

        private async void GoToInfoPage()
        {
            await App.Navigator.PushAsync(new InfoBrandPage());
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
