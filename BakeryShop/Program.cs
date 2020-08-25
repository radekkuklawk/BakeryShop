using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BakeryShop
{
    class Program
    {
        static void Main(string[] args)
        {
            BakeryOffer bakeryoffer = new BakeryOffer();
            bakeryoffer.CreatedChoco += CreatedChocoEventHandler;
            bakeryoffer.CreatedVanilla += CreatedVanillaEventHandler;
            bakeryoffer.Run();
            Console.ReadKey();
    


        }

        private static void CreatedChocoEventHandler()
        {
            Console.WriteLine("Info : został dodany dekorator czekolady");
        }
        private static void CreatedVanillaEventHandler()
        {
            Console.WriteLine("Info : został dodany dekorator vanilli");
        }
    }   
}
