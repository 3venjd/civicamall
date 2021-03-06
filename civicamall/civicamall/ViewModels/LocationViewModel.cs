﻿using civicamall.Models;
using civicamall.Views;
using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace civicamall.ViewModels
{
    public class LocationViewModel : BaseViewModel
    {
        private Location locationObject;

        public Location LocationObject
        {
            get { return this.locationObject; }
            set { this.SetValue(ref this.locationObject, value); }
        }

        private ObservableCollection<Product> products;

        public ObservableCollection<Product> Products
        {
            get { return this.products; }
            set { this.SetValue(ref this.products, value); }
        }

        public ICommand GoToPromos { get { return new RelayCommand(GoToPromo); } }

        public ICommand GoToProducts { get { return new RelayCommand(GoToProductList); } }

        public ICommand GoToStores { get { return new RelayCommand(GoToStoreList); } }

        public ICommand GoToMalls { get { return new RelayCommand(GoToMallList); } }

        public ICommand GoToProductDetail { get { return new RelayCommand(GoToProductDetails); } }

        public LocationViewModel()
        {
            LoadData();
        }

        private void LoadData()
        {
            LocationObject = new Location
            {
                Id = 0,
                Name = "El Hueco",
                Header = "BannersCvicaMallCuarta.png",
                Images = new ObservableCollection<LocationImages>
                {
                    new LocationImages
                    {
                        Id = 0,
                        Image = "RedimensionadosHueco_1.jpg"
                    },
                    new LocationImages
                    {
                        Id = 1,
                        Image = "RedimensionadosHueco_2.jpg"
                    },
                    new LocationImages
                    {
                        Id = 2,
                        Image = "RedimensionadosHueco_3.jpg"
                    },
                    new LocationImages
                    {
                        Id = 3,
                         Image = "RedimensionadosHueco_4.jpg"
                    },
                    new LocationImages
                    {
                        Id = 4,
                        Image = "RedimensionadosHueco_5.jpg"
                    },

                }
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
                    IsDiscount = false
                },
                new Product
                {
                    Id = 0,
                    Name = "Zapatillas",
                    Image = "Zapatillas_2.jpg",
                    Base_cost = 90000,
                    Discount = 0,
                    IsFavorite = false,
                    IsDiscount = false

                },
                new Product
                {
                    Id = 1,
                    Name = "Zapatillas",
                    Image = "Zapatillas_3.jpg",
                    Base_cost = 40000,
                    Discount = 30,
                    IsFavorite = false,
                    IsDiscount = true

                },
                new Product
                {
                    Id = 2,
                    Name = "Zapatillas",
                    Image = "Zapatillas_7.jpg",
                    Base_cost = 90000,
                    Discount = 40,
                    IsFavorite = false,
                    IsDiscount = true

                },
                new Product
                {
                    Id = 3,
                    Name = "Zapatillas",
                    Image = "Zapatillas_5.jpg",
                    Base_cost = 110000,
                    Discount = 20,
                    IsFavorite = true,
                    IsDiscount = true

                },
                new Product
                {
                    Id = 4,
                    Name = "Zapatillas",
                    Image = "Zapatillas_6.jpg",
                    Base_cost = 150000,
                    Discount = 0,
                    IsFavorite = true,
                    IsDiscount = false

                },

            };

        }
        private async void GoToPromo()
        {
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
    }
}
