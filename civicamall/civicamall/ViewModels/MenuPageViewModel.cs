using civicamall.Models;
using civicamall.Views;
using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace civicamall.ViewModels
{
    public class MenuPageViewModel : BaseViewModel
    {

        public ObservableCollection<Product> Products { get; set; }

        public ICommand GoOrderHistoryCommand { get { return new RelayCommand(GoOrderHistory); } }

        public ICommand GoWishesCommand { get { return new RelayCommand(GoWishes); } }

        public ICommand GoCouponCommand { get { return new RelayCommand(GoCoupon); } }

        public ICommand GoEmptyShoppingCartCommand { get { return new RelayCommand(GoEmptyCar); } }

        public ICommand GoToPaymentMethodsCommand { get { return new RelayCommand(GoToPaymentMethods); } }


        public MenuPageViewModel()
        {
            LoadData();
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
        }

        private async void GoOrderHistory()
        {
            (App.Current.MainPage as MasterDetailPage).IsPresented = false;
            var mdp = Application.Current.MainPage as MasterDetailPage;
            await mdp.Detail.Navigation.PushAsync(new OrderHistoryPage());

        }

        private async void GoWishes()
        {
            (App.Current.MainPage as MasterDetailPage).IsPresented = false;
            var mdp = Application.Current.MainPage as MasterDetailPage;
            await mdp.Detail.Navigation.PushAsync(new WishesPages());

        }
        private async void GoCoupon()
        {
            (App.Current.MainPage as MasterDetailPage).IsPresented = false;
            var mdp = Application.Current.MainPage as MasterDetailPage;
            await mdp.Detail.Navigation.PushAsync(new CouponPage());

        }

        private async void GoEmptyCar()
        {
            (App.Current.MainPage as MasterDetailPage).IsPresented = false;
            var mdp = Application.Current.MainPage as MasterDetailPage;
            await mdp.Detail.Navigation.PushAsync(new EmptyCartPage());

        }

        private async void GoToPaymentMethods()
        {
            (App.Current.MainPage as MasterDetailPage).IsPresented = false;
            var mdp = Application.Current.MainPage as MasterDetailPage;
            await mdp.Detail.Navigation.PushAsync(new PaymentMethodsPage());
        }
    }
}
