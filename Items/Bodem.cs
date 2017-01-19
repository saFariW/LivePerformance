using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance.Items
{
    public class Bodem : Item
    {
        public Bodem(int artikkelNr, string beschrijving, decimal kPrijs, decimal vPrijs) : base(artikkelNr, beschrijving, kPrijs, vPrijs)
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
