using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryShop
{
    public class CakeDecorator : Cake
    {
        
        public CakeDecorator(string name, string taste, bool gluten, double price) : base(name, taste, gluten, price)
        {

        }      
        public override double CalculateCost()
        {
            return this.CalculateCost();
        }

        public override string GetName()
        {
            return this.GetName();
        }
    }
}
