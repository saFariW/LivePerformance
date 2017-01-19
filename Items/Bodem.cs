using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance.Items
{
    class Bodem : Item
    {
        public int BodemNr { get; set; }

        public Bodem(int bodemNr)
        {
            BodemNr = bodemNr;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
