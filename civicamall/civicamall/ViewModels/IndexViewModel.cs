using civicamall.Models;
using civicamall.Views;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace civicamall.ViewModels
{
    public class IndexViewModel : BaseViewModel
    {
        private ObservableCollection<Store> stores;

        public ObservableCollection<Store> Stores 
        { 
            get { return this.stores; }
            set { this.SetValue(ref this.stores , value); }
        }

        public ObservableCollection<Product> products;

        public ObservableCollection<Product> Products
        {
            get { return this.products; }
            set { this.SetValue(ref this.products, value); }
        }

        public ObservableCollection<Mall> malls;

        public ObservableCollection<Mall> Malls
        {
            get { return this.malls; }
            set { this.SetValue(ref this.malls, value); }
        }

        public ObservableCollection<Brand> brands;

        public ObservableCollection<Brand> Brands
        {
            get { return this.brands; }
            set { this.SetValue(ref this.brands, value); }
        }

        public ICommand GoToPromos { get { return new RelayCommand(GoToPromo); } }

        public ICommand GoToProducts { get { return new RelayCommand(GoToProductList); } }

        public ICommand GoToStores { get { return new RelayCommand(GoToStoreList); } }

        public ICommand GoToMalls { get { return new RelayCommand(GoToMallList); } }

        public ICommand GoToProductDetail { get { return new RelayCommand(GoToProductDetails); } }

        public ICommand GoToLocation { get { return new RelayCommand(GoToLocations); } }

        public ICommand ShowMasterCommand { get { return new RelayCommand(ShowMaster); } }

        

        public IndexViewModel()
        {
            LoadData();
        }

        private void LoadData()
        {
            MainViewModel.GetInstance().MenuMaster = new MenuPageViewModel();
            Stores = new ObservableCollection<Store>
            {
                new Store
                {
                    Id = 0,
                    Title = "Moda",
                    Image = "Moda.jpg"
                },
                new Store
                {
                    Id = 1,
                    Title = "Tecnología",
                    Image = "Tecnologia.jpg"
                },
                new Store
                {
                    Id = 2,
                    Title = "Comida",
                    Image = "Comidas.jpg"
                },
                new Store
                {
                    Id = 3,
                    Title = "Salud",
                    Image = "Salud.jpg"
                },
                new Store
                {
                    Id = 4,
                    Title = "Motos",
                    Image = "Motos.jpg"
                },
                new Store
                {
                    Id = 5,
                    Title = "Carros",
                    Image = "Carros.jpg"
                },
            };
            Products = new ObservableCollection<Product>
            {
                new Product
                {
                    Id = 0,
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
                    IsDiscount = false,
                    Images = new ObservableCollection<ProductImages>
                    {
                        new ProductImages
                        {
                            Id = 0,
                            Image ="zapatillas_1.png"
                        },
                        new ProductImages
                        {
                            Id = 1,
                            Image ="zapatillas_1_1.jpg"
                        },
                        new ProductImages
                        {
                            Id = 2,
                            Image ="zapatillas_1_2.jpg"
                        },
                    },
                    Colors = new ObservableCollection<ProductColor>
                    {
                        new ProductColor
                        {
                            Id = 0,
                            Color="#000000"
                        },
                        new ProductColor
                        {
                            Id = 1,
                            Color="#FF7D27"
                        },
                        new ProductColor
                        {
                            Id = 2,
                            Color="#7E2081"
                        },
                        new ProductColor
                        {
                            Id = 3,
                            Color="#00A09C"
                        },
                        new ProductColor
                        {
                            Id = 4,
                            Color="#FFFFFF"
                        },
                        new ProductColor
                        {
                            Id = 5,
                            Color="#9AAFAF"
                        },
                    },
                    Sizes = new ObservableCollection<ProdcutSize>
                    {
                        new ProdcutSize
                        {
                            Id = 0,
                            Size="29"
                        },
                        new ProdcutSize
                        {
                            Id = 1,
                            Size="32"
                        },
                        new ProdcutSize
                        {
                            Id = 2,
                            Size="35"
                        },
                        new ProdcutSize
                        {
                            Id = 3,
                            Size="39"
                        },
                        new ProdcutSize
                        {
                            Id = 4,
                            Size="42"
                        },
                        new ProdcutSize
                        {
                            Id = 5,
                            Size="45"
                        },
                    }

                },
                new Product
                {
                    Id = 1,
                    Name = "Zapatillas",
                    Image = "Zapatillas_2.jpg",
                    Base_cost = 90000,
                    Discount = 0,
                    IsFavorite = false,
                    IsDiscount = false

                },
                new Product
                {
                    Id = 2,
                    Name = "Zapatillas",
                    Image = "Zapatillas_3.jpg",
                    Base_cost = 40000,
                    Discount = 30,
                    IsFavorite = false,
                    IsDiscount = true

                },
                new Product
                {
                    Id = 3,
                    Name = "Zapatillas",
                    Image = "Zapatillas_7.jpg",
                    Base_cost = 90000,
                    Discount = 40,
                    IsFavorite = false,
                    IsDiscount = true
                },
                new Product
                {
                    Id = 4,
                    Name = "Zapatillas",
                    Image = "Zapatillas_5.jpg",
                    Base_cost = 110000,
                    Discount = 20,
                    IsFavorite = true,
                    IsDiscount = true

                },
                new Product
                {
                    Id = 5,
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
                    Id = 0,
                    Name = "Mayorca",
                    Image ="Mayorca_logo.png"
                },
                new Mall
                {
                    Id = 1,
                    Name = "Oviedo",
                    Image = "Oviedo_logo.png"
                },
                new Mall
                {
                    Id = 2,
                    Name = "Santa fe",
                    Image = "Santafe_logo.png"

                }
            };
            Brands = new ObservableCollection<Brand>
            {
                new Brand
                {
                    Id = 0,
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
                    Id = 1,
                    Name = "RIFLE",
                    Image = "Rifle_logo.png",
                    IsOpen = false,
                    IsClose = false,
                    Open_Hour = "7:00 AM",
                },
                new Brand
                {
                    Id = 2,
                    Name = "AMERICANINO",
                    Image = "Americanino_logo.png",
                    IsOpen = false,
                    IsClose = true,
                    Open_Hour = "8:30 AM",
                },
                new Brand
                {
                    Id = 3,
                    Name = "NIKE",
                    Image = "Nike_logo.jgg",
                    IsOpen = false,
                    IsClose = true,
                    Open_Hour = "8:30 AM",
                },
            };
        }

        private async void GoToPromo()
        {
            /*var mdp = Application.Current.MainPage as MasterDetailPage;

            await Task.WhenAll(
                mdp.RotateXTo(100, 600, Easing.SinOut),
                mdp.FadeTo(0, 600)
                );

            await mdp.Detail.Navigation.PushAsync(new PromosPage());

            await Task.WhenAll(
               mdp.RotateXTo(0, 600),
               mdp.FadeTo(1, 600, Easing.SinIn)
               );

            // Application.Current.MainPage = new NavigationPage(new PromosPage());
            // await Application.Current.MainPage.Navigation.PushAsync(new PromosPage());
            */
            MainViewModel.GetInstance().Promos = new PromosViewModel();
            await App.Navigator.PushAsync(new PromosPage());

        }
        private async void GoToProductList()
        {
            MainViewModel.GetInstance().Products = new ProductsViewModel();
            await App.Navigator.PushAsync(new ProductsPage());
        }
        private async void GoToStoreList()
        {
            MainViewModel.GetInstance().Store = new StoreViewModel();
            await App.Navigator.PushAsync(new StorePage());
        }
        private async void GoToMallList()
        {
            MainViewModel.GetInstance().Malls = new MallsViewModel();
            await App.Navigator.PushAsync(new MallPage());
        }

        private async void GoToProductDetails()
        {
            MainViewModel.GetInstance().Products = new ProductsViewModel();
            await App.Navigator.PushAsync(new ProductDetailPage());
        }


        private async void GoToLocations()
        {
            MainViewModel.GetInstance().Location = new LocationViewModel();
            await App.Navigator.PushAsync(new LocationPage());
        }

        

        private void ShowMaster()
        {
            (App.Current.MainPage as MasterDetailPage).IsPresented = true;
        }

        






    }
}
