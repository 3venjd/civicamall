using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace civicamall.Models
{
    public class Location
    {
        public string Name { get; set; }

        public ObservableCollection<LocationImages> Images { get; set; }
    }
}
