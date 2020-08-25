using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryShop
{
    class BakeryOffer
    {
        private Printer _printer;
        public event Action CreatedChoco;
        public event Action CreatedVanilla;

        public BakeryOffer()
        {
            _printer = new Printer();
        }
        public void Run()
        {
           
            Cake biscuit;
            Cake muffin;

            Menu();
            biscuit = CreateNewBiscuit();
            muffin = CreateNewMuffin();
            Console.WriteLine();
            _printer.Print(biscuit);
            _printer.Print(muffin);
            Console.ReadKey();

            biscuit = CreateChocoDecorator(biscuit);
            muffin = CreateChocoDecorator(muffin);
            _printer.Print(biscuit);
            _printer.Print(muffin);
            Console.ReadKey();

            biscuit = CreateVanillaDecorator(biscuit);
            muffin =CreateVanillaDecorator(muffin);
            _printer.Print(biscuit);
            _printer.Print(muffin);
            Console.ReadKey();


        }
        private void Menu()
        {
           
            Console.WriteLine("1 - Biscuit");
            Console.WriteLine("2 - Muffin");
            Console.ReadKey();         
        }


     
        private Biscuit CreateNewBiscuit()
        {
            return new Biscuit();
        }

        private Muffin CreateNewMuffin()
        {
           return new Muffin();
          
        }

        private ChocoladeDecorator CreateChocoDecorator(Cake cake)
        {
            CreatedChoco();
            return new ChocoladeDecorator(cake);      
        }

        private VanillaDecorator CreateVanillaDecorator(Cake cake)
        {
            CreatedVanilla();
            return new VanillaDecorator(cake);          
        }
    }
}
