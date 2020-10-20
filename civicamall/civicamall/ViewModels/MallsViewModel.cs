using civicamall.Models;
using civicamall.Views;
using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace civicamall.ViewModels
{
    public class MallsViewModel : BaseViewModel
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

        private ObservableCollection<Product> products;
        public ObservableCollection<Product> Products
        {
            get { return this.products; }
            set { this.SetValue(ref this.products, value); }
        }

        private ObservableCollection<Mall> malls;

        public ObservableCollection<Mall> Malls
        {
            get { return this.malls; }
            set { this.SetValue(ref this.malls, value); }
        }

        private Mall mallDetail;

        public Mall MallDetail
        {
            get { return this.mallDetail; }
            set { this.SetValue(ref this.mallDetail, value); }
        }

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
            await App.Navigator.PushAsync(new MallDetailPage());
        }
        private async void GoToPromo()
        {
            await App.Navigator.PushAsync(new PromosPage());
        }

        private async void GoToStore()
        {
            await App.Navigator.PushAsync(new StorePage());
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
