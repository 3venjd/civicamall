﻿using System;
using System.Collections.Generic;
using System.Text;

namespace civicamall.Models
{
    public class Product
    {
        public string Name { get; set; }

        public string Image { get; set; }

        public string Brand { get; set; }

        public string Icon_brand { get; set; }

        public string Description { get; set; }

        public float Base_cost { get; set; }

        public bool IsDiscount { get; set; }

        public bool IsFavorite { get; set; }

        public float Discount { get; set; }

        public string ShowDiscount => $"-{Discount}%";

        public float Final_cost => Base_cost - (Base_cost * (Discount / 100));
    }
}
