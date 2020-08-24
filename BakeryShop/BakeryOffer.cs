using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryShop
{
    class BakeryOffer
    {
        public static List<Cake> GenerateListofCake()
        {
            return new List<Cake>
            {
                new Muffin(){Name = "Ciastko1", Taste = "cream", Gluten = true, Price = 22.5},
                new Muffin(){Name = "Ciastko2", Taste = "sweet", Gluten = false, Price = 12.5},
                new Muffin(){Name = "Ciastko3", Taste = "cream", Gluten = true, Price = 222.5},
                new Biscuit(){Name = "Ciastko4", Taste = "very sweet", Gluten = false, Price = 11.5},
                new Biscuit(){Name = "Ciastko5", Taste = "cream", Gluten = true, Price = 102.2},
            };
        }
    }
}
