using civicamall.Models;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace civicamall.ViewModels
{
    public class ShoppingViewModel
    {
        public ObservableCollection<ShoppingCar> ProductsInCar { get; set; }

        public ICommand Backtopreviospage { get { return new RelayCommand(Backpage); } }
        public ShoppingViewModel()
        {
            ProductsInCar = new ObservableCollection<ShoppingCar>
            {
                new ShoppingCar
                {
                     Name = "Zapatillas",
                     Image = "zapatillas_1.png",
                     Discount = 0,
                     IsDiscount = false

                },
                new ShoppingCar
                {
                     Name = "Vestido",
                     Image = "Vestido_1_1.jpg",
                     Base_cost = 90000,
                     Discount = 0,
                     IsDiscount = false

                },
                new ShoppingCar
                {
                     Name = "Gorra",
                     Image = "gorra_1.jpg",
                     Base_cost = 40000,
                     Discount = 30,
                     IsDiscount = true

                },
                new ShoppingCar
                {
                     Name = "Camiseta",
                     Image = "camiseta_1.jpg",
                     Base_cost = 90000,
                     Discount = 40,
                     IsDiscount = true

                },
                new ShoppingCar
                {
                     Name = "Pantalon",
                     Image = "pantalon_1",
                     Base_cost = 110000,
                     Discount = 20,
                     IsDiscount = true

                },

            };
        }

        private async void Backpage()
        {
            var mdp = Application.Current.MainPage as MasterDetailPage;
            await mdp.Detail.Navigation.PopAsync();
        }

    }
}
