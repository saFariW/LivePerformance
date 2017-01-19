using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance
{
    class Bestelling
    {
        public List<Item> Items { get; set; }
        public int BestellingNr { get; set; }
        public Status Status { get; set; }
        public DateTime Besteld { get; set; }

        public Bestelling(List<Item> items, int bestellingNr, Status status, DateTime besteld)
        {
            Items = items;
            BestellingNr = bestellingNr;
            Status = status;
            Besteld = besteld;
        }

        public Bestelling(List<Item> items, Status status, DateTime besteld)
        {
            Items = items;
            Status = status;
            Besteld = besteld;
        }

        public decimal BerekenPrijs()
        {
           throw new NotImplementedException();
        }
    }
}
