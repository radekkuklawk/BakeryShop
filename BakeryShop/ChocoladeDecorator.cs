using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryShop
{
    class ChocoladeDecorator : CakeDecorator
    {
        public ChocoladeDecorator(Cake cake) : base(cake)
        {

        }
        public override double CalculateCost()
        {
            return base.CalculateCost() + 5.15;
        }

        public override string GetName()
        {
            return base.GetName() + " Chocolade";
        }
    }
}
