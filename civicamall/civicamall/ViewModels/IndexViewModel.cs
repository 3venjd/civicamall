using civicamall.Models;
using civicamall.Views;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace civicamall.ViewModels
{
    public class IndexViewModel : BaseViewModel
    {
        public ObservableCollection<Store> Stores { get; set; }

        public ObservableCollection<Product> Products { get; set; }

        public ObservableCollection<Mall> Malls { get; set; }

        public ObservableCollection<Brand> Brands { get; set; }

        public ICommand GoToPromos { get { return new RelayCommand(GoToPromo); } }

        public ICommand GoToProducts { get { return new RelayCommand(GoToProductList); } }

        public ICommand GoToStores { get { return new RelayCommand(GoToStoreList); } }

        public ICommand GoToMalls { get { return new RelayCommand(GoToMallList); } }

        public ICommand GoToProductDetail { get { return new RelayCommand(GoToProductDetails); } }

        public ICommand GoToLocation { get { return new RelayCommand(GoToLocations); } }

        public ICommand ShowMasterCommand { get { return new RelayCommand(ShowMaster); } }

        public ICommand GoToNotAvailableCommand { get { return new RelayCommand(GoToNotAvailable); } }

        public ICommand ErrorPageCommand { get { return new RelayCommand(ErrorPageLoad); } }

        public ICommand GoToYourMallsCommand { get { return new RelayCommand(GoToYourMalls); } }

        public ICommand GoToYourStoresCommand { get { return new RelayCommand(GoToYourStores); } }

        public ICommand GoToYourVisitedPlacesCommand { get { return new RelayCommand(GoToYourVisitedPlaces); } }

        public ICommand GoToCarCommand { get { return new RelayCommand(GoCar); } }

        public IndexViewModel()
        {
            LoadData();
        }

        private void LoadData()
        {
            
            Stores = new ObservableCollection<Store>
            {
                new Store
                {
                    Title = "Moda",
                    Image = "Moda.jpg"
                },
                new Store
                {
                    Title = "Tecnología",
                    Image = "Tecnologia.jpg"
                },
                new Store
                {
                    Title = "Comida",
                    Image = "Comidas.jpg"
                },
                new Store
                {
                    Title = "Salud",
                    Image = "Salud.jpg"
                },
                new Store
                {
                    Title = "Motos",
                    Image = "Motos.jpg"
                },
                new Store
                {
                    Title = "Carros",
                    Image = "Carros.jpg"
                },
            };
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
                     Image = "Nike_logo.jgg",
                     IsOpen = false,
                     IsClose = true,
                     Open_Hour = "8:30 AM",
                },
            };
        }

        private async void GoToPromo()
        {
           var mdp = Application.Current.MainPage as MasterDetailPage;
           await mdp.Detail.Navigation.PushAsync(new PromosPage());

           // Application.Current.MainPage = new NavigationPage(new PromosPage());
           // await Application.Current.MainPage.Navigation.PushAsync(new PromosPage());

        }
        private async void GoToProductList()
        {
            var mdp = Application.Current.MainPage as MasterDetailPage;
            await mdp.Detail.Navigation.PushAsync(new ProductsPage());
        }
        private async void GoToStoreList()
        {
            var mdp = Application.Current.MainPage as MasterDetailPage;
            await mdp.Detail.Navigation.PushAsync(new StorePage());
        }
        private async void GoToMallList()
        {
            var mdp = Application.Current.MainPage as MasterDetailPage;
            await mdp.Detail.Navigation.PushAsync(new MallPage());
        }

        private async void GoToProductDetails()
        {
            var mdp = Application.Current.MainPage as MasterDetailPage;
            await mdp.Detail.Navigation.PushAsync(new ProductDetailPage());
        }
        private async void GoToLocations()
        {
            var mdp = Application.Current.MainPage as MasterDetailPage;
            await mdp.Detail.Navigation.PushAsync(new LocationPage());
        }

        private async void GoToNotAvailable()
        {
            var mdp = Application.Current.MainPage as MasterDetailPage;
            await mdp.Detail.Navigation.PushAsync(new NotAvailableProduct());
        }

        private async void ErrorPageLoad()
        {
            var mdp = Application.Current.MainPage as MasterDetailPage;
            await mdp.Detail.Navigation.PushAsync(new ErrorPage());
        }

        private async void GoToYourMalls()
        {
            var mdp = Application.Current.MainPage as MasterDetailPage;
            await mdp.Detail.Navigation.PushAsync(new YourMallsPage());
        }

        private async void GoToYourStores()
        {
            var mdp = Application.Current.MainPage as MasterDetailPage;
            await mdp.Detail.Navigation.PushAsync(new YourStoresPage());
        }

        private async void GoToYourVisitedPlaces()
        {
            var mdp = Application.Current.MainPage as MasterDetailPage;
            await mdp.Detail.Navigation.PushAsync(new YourVisitedPlacesPage());
        }
        
        private async void GoCar()
        {


            var mdp = Application.Current.MainPage as MasterDetailPage;

            await Task.WhenAll(
                //mdp.ScaleTo(0, 1000),
                mdp.FadeTo(0,600)
            );
             

            await mdp.Detail.Navigation.PushAsync(new ShoppingCarPage());

            await Task.WhenAll(
                //mdp.ScaleTo(1, 1000, Easing.CubicIn),
                mdp.FadeTo(1,600, Easing.CubicIn)
                );

            

        }

        private void ShowMaster()
        {
            (App.Current.MainPage as MasterDetailPage).IsPresented = true;
        }

        




    }
}
