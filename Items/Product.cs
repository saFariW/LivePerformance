using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance
{
    class Product : Item
    {
        public int ProductNr { get; set; }
        public bool Alcohol { get; set; }

        public Product(int productNr, bool alcohol)// : base (artikkelNr, beschrijving, kPrijs, vPrijs)
        {
            ProductNr = productNr;
            Alcohol = alcohol;
        }
    }
}
