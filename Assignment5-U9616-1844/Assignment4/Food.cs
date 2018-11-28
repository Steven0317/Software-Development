using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Food : Supplies
    {
        public string TypeOfPet { get; set; }
        public int Weight { get; set; }
        public string Flavor { get; set; }

        public Food(string name, string description, double price, int stock, string path
                    , string type)
        {
            Name = name;
            Description = description;
            Price = price;
            Stock = stock;
            ImagePath = path;
            TypeOfPet = type;
            
           
        }
    }
}
