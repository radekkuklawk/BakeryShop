using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryShop
{
    class Biscuit : Cake
    {
       
        public override double CalculateCost()
        {
            return 25.00;
        }

        public override string GetName()
        {
            return "biscuit";
        }

    }
}
