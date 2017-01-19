using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance.Items
{
    class Ingredient : Item
    {
        public bool Halal { get; set; }
        public bool Vega { get; set; }

        public Ingredient(int artikkelNr, string beschrijving, decimal kPrijs, decimal vPrijs, bool halal, bool vega) : base(artikkelNr, beschrijving, kPrijs, vPrijs)
        {
            Halal = halal;
            Vega = vega;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
