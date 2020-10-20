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
                    Image ="zapatillas_1.png"
                },
                new ProductImages
                {
                    Image ="zapatillas_1_1.jpg"
                },
                new ProductImages
                {
                    Image ="zapatillas_1_2.jpg"
                },
            };

            Categories = new ObservableCollection<Category>
            {
                new Category
                {
                    Name = "Calzado",
                    Image = "Calzado.jpg"
                },
                new Category
                {
                    Name = "Camisetas",
                    Image = "Camisetas.jpg"
                },
                new Category
                {
                    Name = "Vestidos",
                    Image = "Vestidos.jpg"
                },
                new Category
                {
                    Name = "Pantalones",
                    Image = "Pantalones.jpg"
                },
                new Category
                {
                    Name = "Gorras",
                    Image = "Gorras.jpg"
                },
            };

            Sizes = new ObservableCollection<ProdcutSize>
            {
                new ProdcutSize
                {
                    Size="29"
                },
                new ProdcutSize
                {
                    Size="32"
                },
                new ProdcutSize
                {
                    Size="35"
                },
                new ProdcutSize
                {
                    Size="39"
                },
                new ProdcutSize
                {
                    Size="42"
                },
                new ProdcutSize
                {
                    Size="45"
                },
            };

            Colors = new ObservableCollection<ProductColor>
            {
                new ProductColor
                {
                    Color="#000000"
                },
                new ProductColor
                {
                    Color="#FF7D27"
                },
                new ProductColor
                {
                    Color="#7E2081"
                },
                new ProductColor
                {
                    Color="#00A09C"
                },
                new ProductColor
                {
                    Color="#FFFFFF"
                },
                new ProductColor
                {
                    Color="#9AAFAF"
                },
            };

            Productdetail = new Product 
            {
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
