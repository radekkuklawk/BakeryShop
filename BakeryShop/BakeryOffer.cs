using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryShop
{
    class BakeryOffer
    {
        private Biscuit CreateNewBiscuit()
        {
            return new Biscuit();
        }

        private Muffin CreateNewMuffin()
        {
            return new Muffin();
        }
    }
}
