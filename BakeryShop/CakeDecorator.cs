using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryShop
{
    public class CakeDecorator : Cake
    {
        protected Cake _cake;

        public CakeDecorator(Cake cake)
        {
            _cake = cake;
        }
        public override double CalculateCost()
        {
            return _cake.CalculateCost();
        }

        public override string GetName()
        {
            return _cake.GetName();
        }
    }
}
