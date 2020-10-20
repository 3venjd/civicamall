using System;
using System.Collections.Generic;
using System.Text;

namespace civicamall.Models
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Image { get; set; }

        public string Open_Day { get; set; }

        public string Close_Day { get; set; }

        public string Open_Hour { get; set; }

        public string CLose_hour { get; set; }

        public string Description { get; set; }

        public string Url_Web { get; set; }

        public string Url_Facebook { get; set; }

        public string Url_Instagram { get; set; }

        public string Url_Twitter { get; set; }

        public string Url_Youtube { get; set; }

        public bool Saturday_Open { get; set; }

        public bool HolyDay_open { get; set; }

        public bool IsOpen { get; set; }

        public bool IsClose { get; set; }
    }
}
