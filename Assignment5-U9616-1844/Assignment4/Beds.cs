﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Beds : Supplies
    {
        public string Size { get; set; }
        public string Material { get; set; }

        public Beds(string name, string description, double price, int stock, string path,
                        string size, string material)
        {
            Name = name;
            Description = description;
            Price = price;
            Stock = stock;
            ImagePath = path;
            Size = size;
            Material = material;
        }

    }
}
