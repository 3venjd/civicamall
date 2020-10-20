using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace civicamall.Models
{
    public class Location
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Header { get; set; }
        public ObservableCollection<LocationImages> Images { get; set; }
    }
}
