using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivePerformance.DataAccesLayer.ContextInterfaces;

namespace LivePerformance.DataAccesLayer.SQLContext
{
    class BestellingSql :IBestellingContext
    {
        public bool MaakBestelling(List<Item> items, int bestellingNr, Status status, DateTime besteld)
        {
            throw new NotImplementedException();
        }

        public List<Bestelling> HaalAllenBestellingen()
        {
            throw new NotImplementedException();
        }

        public List<Bestelling> HaalBestellingenVanKlant(int klantNr)
        {
            throw new NotImplementedException();
        }
    }
}
