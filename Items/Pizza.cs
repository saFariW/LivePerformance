using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance.Items
{
    class Pizza : Item
    {
        public int PizzaNr { get; set; }
        public Vorm Vorm { get; set; }
        public decimal Oppervlak { get; set; }
        public string Formaat { get; set; }

        public decimal BerekenPrijs()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
