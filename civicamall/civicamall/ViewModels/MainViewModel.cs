using civicamall.Controls;
using civicamall.Views;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace civicamall.ViewModels
{
    public class MainViewModel
    {
        public IndexViewModel Index { get; set; }

        public BrandProductsViewModel BrandProducts { get; set; }

        public LocationViewModel Location { get; set; }

        public MallsViewModel Malls { get; set; }

        public MenuPageViewModel MenuMaster { get; set; }

        public ModeSelectionViewModel ModeSelection { get; set; }

        public OnBoardingViewModel OnBoarding { get; set; }

        public ProductsViewModel Products { get; set; }

        public PromosViewModel Promos { get; set; }

        public StoreViewModel Store { get; set; }

        public HeaderControlViewModel HeaderControl { get; set; }

        public LoginViewModel Login { get; set; }

        public MainViewModel()
        {
            instance = this;
            this.ModeSelection = new ModeSelectionViewModel();
            this.HeaderControl = new HeaderControlViewModel();
            
        }

        private static MainViewModel instance;

        public static MainViewModel GetInstance()
        {
            if (instance == null)
            {
                return new MainViewModel();
            }
            return instance;
        }

        public ICommand GoToCarCommand { get { return new RelayCommand(GoCar); } }

        private async void GoCar()
        {
            this.Store = new StoreViewModel();
            await App.Navigator.PushAsync(new ShoppingCarPage());
        }

    }
}
