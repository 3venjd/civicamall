﻿using civicamall.Models;
using civicamall.ViewModels;
using civicamall.Views;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace civicamall.Controls
{
    public class HeaderControlViewModel: BaseViewModel
    {
        public ObservableCollection<Advertisement> Advertisements { get; set; }

        private ObservableCollection<Product> _products;
        public ObservableCollection<Product> Products
        {
            get => _products;
            set 
            {
                _products = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<Mall> Malls { get; set; }

        public ICommand GoBackCommand { get { return new RelayCommand(GoBack); } }

        public ICommand GoToCarCommand { get { return new RelayCommand(GoCar); } }

        public ICommand GoNotFoundCommand { get { return new RelayCommand(GoNotFound); } }

        private int _position;

        public int Position
        {
            get => _position;
            set
            {
                _position = value;
                OnPropertyChanged();
            }
        }

        public HeaderControlViewModel()
        {
            LoadData();
            Slider();
        }

        private void LoadData()
        {
            Advertisements = new ObservableCollection<Advertisement>
            {
                new Advertisement
                {
                    Title = "Promo 1",
                    Image = "RedimensionadosBanner_1.jpg"
                },
                new Advertisement
                {
                    Title = "Promo 2",
                    Image = "RedimensionadosBanner_2.jpg"
                },
                new Advertisement
                {
                    Title = "Promo 3",
                    Image = "RedimensionadosBanner_3.jpg"
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

        }

        private async void GoCar()
        {
            await App.Navigator.PushAsync(new ShoppingCarPage());
        }
        
        private async void GoNotFound()
        {
            await App.Navigator.PushAsync(new NotFoundPage());
        }

        

        private async void GoBack()
        {
            await App.Navigator.PopAsync();
        }
        private void Slider()
        {
            Device.StartTimer(TimeSpan.FromSeconds(5), (Func<bool>)(() =>
            {
                Position = (Position + 1) % Advertisements.Count;
                return true;
            }));
        }
    }
}
