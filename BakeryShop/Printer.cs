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
            Console.WriteLine($"Nazwa: {cake.Name}");
            Console.WriteLine($"Smak: {cake.Taste}");
            Console.WriteLine($"Czy zawiera Gluten: {cake.Gluten}");
            Console.WriteLine($"Cena:{cake.Price}");
            
            Console.WriteLine();
        }
    }
}
