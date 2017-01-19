using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance.DataAccesLayer.ContextInterfaces
{
    interface IBestellingContext
    {
        bool MaakBestelling(List<Item> items, int bestellingNr, Status status, DateTime besteld);
        List<Bestelling> HaalAllenBestellingen();
        List<Bestelling> HaalBestellingenVanKlant(int klantNr);
    }
}
