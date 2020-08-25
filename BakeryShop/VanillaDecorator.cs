using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryShop
{
    class VanillaDecorator : CakeDecorator
    {
        public VanillaDecorator(Cake cake) : base(cake)
        {

        }

        public override double CalculateCost()
        {
            return base.CalculateCost() + 2.15;
        }

        public override string GetName()
        {
            return base.GetName() + "Vanilla";
        }
    }
}
