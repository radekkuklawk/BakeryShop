using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryShop
{
    class Muffin : Cake
    {
        
        public override double CalculateCost()
        {
            return 10;
        }

        public override string GetName()
        {
            return "Muffin";
        }
    }
}
