using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class WaterPet : Pets
    {
        public string TypeOfPet { get; set; }
        public bool HasFins { get; private set; }

        public WaterPet(string name, double price, string imagePath, int stock)
        {
            Name = name;
            Price = price;
            ImagePath = imagePath;
            Stock = stock;
            TypeOfPet = "Water";
            
        }
    }
}
