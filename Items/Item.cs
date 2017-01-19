using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance
{
    public abstract class Item : IComparable<Item>
    {
        public int ArtikkelNr { get; set; }
        public string Beschrijving { get; set; }
        public decimal KPrijs { get; set; }
        public decimal VPrijs { get; set; }

        public int CompareTo(Item other)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
