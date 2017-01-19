using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance
{
    class Product : Item
    {
        public bool Alcohol { get; set; }
        public Product( int artikkelNr, string beschrijving, decimal kPrijs, decimal vPrijs, bool alcohol) : base(artikkelNr, beschrijving, kPrijs, vPrijs)
        {
            Alcohol = alcohol;
        }
    }
}
