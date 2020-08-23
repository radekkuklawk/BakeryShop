using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryShop
{
    public abstract class Cake
    {
       
        public string Name { get => Name; protected set => Name = value; }
        public string Taste { get;}
        public bool Gluten { get;}
        public double Price { get => Price; protected set => Price = value;}


        public abstract double CalculateCost();

        public abstract string GetName();
    

}
}
