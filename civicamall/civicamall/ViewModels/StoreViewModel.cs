using civicamall.Models;
using civicamall.Views;
using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xam.TabView;
using Xam.TabView.Control;
using Xamarin.Forms;

namespace civicamall.ViewModels
{
    public class StoreViewModel : BaseViewModel
    {
        public ObservableCollection<Advertisement> Advertisements { get; set; }

        public ObservableCollection<Brand> Brands { get; set; }

        public ObservableCollection<Product> Products { get; set; }

        //public XFTabControl Tabcomponent { get; set; }

        public ICommand GoToBrand { get { return new RelayCommand(GoToProductBrand); } }

        public StoreViewModel()
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
                     Image = "ic_adidas.png",
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
                     Image = "ic_rifle.png",
                     IsOpen = false,
                     IsClose = false,
                     Open_Hour = "7:00 AM",
                },
                new Brand
                {
                     Name = "AMERICANINO",
                     Image = "ic_americanino.png",
                     IsOpen = false,
                     IsClose = true,
                     Open_Hour = "8:30 AM",
                },
                new Brand
                {
                     Name = "NIKE",
                     Image = "ic_nike.jgg",
                     IsOpen = false,
                     IsClose = true,
                     Open_Hour = "8:30 AM",
                },
            };

        }
        private async void GoToProductBrand()
        {
            var mdp = Application.Current.MainPage as MasterDetailPage;
            await mdp.Detail.Navigation.PushAsync(new TabbedBrandPage());
        }
    }
}
