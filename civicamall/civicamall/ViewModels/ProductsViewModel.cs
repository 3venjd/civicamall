using civicamall.Models;
using civicamall.Views;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace civicamall.ViewModels
{
    public class ProductsViewModel : BaseViewModel
    {
        private ObservableCollection<Category> categories;

        public ObservableCollection<Category> Categories
        {
            get { return this.categories; }
            set { this.SetValue(ref this.categories, value); }
        }

        private ObservableCollection<ProductImages> productImages;

        public ObservableCollection<ProductImages> ProductImages
        {
            get { return this.productImages; }
            set { this.SetValue(ref this.productImages, value); }
        }

        private ObservableCollection<ProdcutSize> sizes;
        public ObservableCollection<ProdcutSize> Sizes
        {
            get { return this.sizes; }
            set { this.SetValue(ref this.sizes, value); }
        }

        private ObservableCollection<ProductColor> colors;

        public ObservableCollection<ProductColor> Colors
        {
            get { return this.colors; }
            set { this.SetValue(ref this.colors, value); }
        }

        private Product productdetail;
        public Product Productdetail
        {
            get { return this.productdetail; }
            set { this.SetValue(ref this.productdetail, value); }
        }

        public ICommand GoToCarCommand { get { return new RelayCommand(GoCar); } }

        private int _position;

        public int Position
        {

            get { return this._position; }
            set { this.SetValue(ref this._position, value); }

        }

        public ProductsViewModel()
        {

            ProductImages = new ObservableCollection<ProductImages>
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
            };

            Categories = new ObservableCollection<Category>
            {
                new Category
                {
                    Id = 0,
                    Name = "Calzado",
                    Image = "Calzado.jpg"
                },
                new Category
                {
                    Id = 1,
                    Name = "Camisetas",
                    Image = "Camisetas.jpg"
                },
                new Category
                {
                    Id = 2,
                    Name = "Vestidos",
                    Image = "Vestidos.jpg"
                },
                new Category
                {
                    Id = 3,
                    Name = "Pantalones",
                    Image = "Pantalones.jpg"
                },
                new Category
                {
                    Id = 4,
                    Name = "Gorras",
                    Image = "Gorras.jpg"
                },
            };

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
            };

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
            };

            Productdetail = new Product 
            {
                Id = 0,
                Name = "Zapatillas",
                Image = "zapatillas_1",
                Brand = "Nike",
                Icon_brand = "Nike_logo.jpg",
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
            };

            Slider();
        }

        private async void GoCar()
        {
            MainViewModel.GetInstance().Store = new StoreViewModel();
            await App.Navigator.PushAsync(new ShoppingCarPage());
        }

        private void Slider()
        {
            Device.StartTimer(TimeSpan.FromSeconds(5), (Func<bool>)(() =>
            {
                Position = (Position + 1) % ProductImages.Count;
                return true;
            }));
        }
    }
}
