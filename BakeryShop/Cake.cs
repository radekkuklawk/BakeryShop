using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryShop
{
    public abstract class Cake
    {
       
        public string Name { get ; set;}
        public string Taste { get; set;}
        public bool Gluten { get; set;}
        public double Price { get; set;}

        public Cake()
        { }

        public Cake (string name, string taste, bool gluten, double price)
        {
            this.Name = name;
            this.Taste = taste;
            this.Gluten = gluten;
            this.Price = price;
        }


        public abstract double CalculateCost();

        public abstract string GetName();
    

}
}
