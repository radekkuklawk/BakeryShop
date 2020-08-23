using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryShop
{
    public abstract class Cake
    {
        private string name;

        public string Name { get => name; protected set => name = value; }
        public string Taste { get;}
        public bool Gluten { get;}
        public double Price { get; set;}


        public abstract double CalculateCost();

        public abstract string GetName();
    

}
}
