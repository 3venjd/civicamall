using civicamall.Models;
using civicamall.Views;
using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace civicamall.ViewModels
{
    public class LocationViewModel
    {
        public Location LocationObject { get; set; }

        public ObservableCollection<Product> Products { get; set; }

        public ICommand GoToPromos { get { return new RelayCommand(GoToPromo); } }

        public ICommand GoToProducts { get { return new RelayCommand(GoToProductList); } }

        public ICommand GoToStores { get { return new RelayCommand(GoToStoreList); } }

        public ICommand GoToMalls { get { return new RelayCommand(GoToMallList); } }

        public ICommand GoToProductDetail { get { return new RelayCommand(GoToProductDetails); } }

        public LocationViewModel()
        {
            LocationObject = new Location
            {
                Name = "El Hueco",
                Header = "city_image.png",
                Images = new ObservableCollection<LocationImages>
                {
                    new LocationImages
                    {
                         Image = "Banner_el_huecoImagen_1.jpg"
                    },
                    new LocationImages
                    {
                         Image = "Banner_el_huecoImagen_2.jpg"
                    },
                    new LocationImages
                    {
                         Image = "Banner_el_huecoMesa_de_trabajo_1.jpg"
                    },
                    new LocationImages
                    {
                         Image = "Banner_el_huecoMesa_de_trabajo_2.jpg"
                    },
                    new LocationImages
                    {
                         Image = "Banner_el_huecoMesa_de_trabajo_4.jpg"
                    },

                }
            };

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
        }

        private async void GoToPromo()
        {
            var mdp = Application.Current.MainPage as MasterDetailPage;
            await mdp.Detail.Navigation.PushAsync(new PromosPage());

            //Application.Current.MainPage = new NavigationPage(new PromosPage());
            //await Application.Current.MainPage.Navigation.PushAsync(new PromosPage());

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
    }
}
