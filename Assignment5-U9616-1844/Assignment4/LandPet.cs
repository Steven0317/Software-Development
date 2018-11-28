using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class LandPet : Pets
    {
        public string TypeOfPet { get; set; }
        public int NumberOfLegs { get; set; }
        
        public LandPet(string name, double price, string imagePath, int stock)
        {
            Name = name;
            Price = price;
            ImagePath = imagePath;
            Stock = stock;
            TypeOfPet = "land";
            
        }
    }
}
