using civicamall.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace civicamall.ViewModels
{
    public class IndexViewModel : BaseViewModel
    {
        public ObservableCollection<Advertisement> Advertisements { get; set; }

        public ObservableCollection<Store> Stores { get; set; }
        public IndexViewModel()
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

            Stores = new ObservableCollection<Store>
            {
                new Store
                {
                    Title = "Helados",
                    Image = "ice_cream.png"
                },
                new Store
                {
                    Title = "Telas",
                    Image = "cloths.png"
                },
                new Store
                {
                    Title = "Ferretería",
                    Image = "hadware_store.png"
                },
            };

        }
    }
}
