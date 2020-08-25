using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryShop
{
    class Printer : IPrint
    {
        public void Print(Cake cake)
        {
            Console.WriteLine("{0:C2}", cake.CalculateCost());
            Console.WriteLine(cake.GetName());

        }



    }
}
