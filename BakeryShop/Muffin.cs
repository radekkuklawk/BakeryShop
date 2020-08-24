using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryShop
{
    class Muffin : Cake
    {
        public Muffin() : base()
        {

        }
        public Muffin(string name, string taste, bool gluten, double price) : base(name, taste, gluten, price)
        {

        }
        public override double CalculateCost()
        {
            return this.Price;
        }

        public override string GetName()
        {
            return this.Name;
        }
    }
}
