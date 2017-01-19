using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivePerformance.DataAccesLayer.ContextInterfaces;

namespace LivePerformance.DataAccesLayer.Repository
{
    public class BestellingRepo
    {
        private readonly IBestellingContext _context;

        public BestellingRepo(IBestellingContext context)
        {
            _context = context;
        }

        bool MaakBestelling(List<Item> items, int bestellingNr, Status status, DateTime besteld)
        {
            return _context.MaakBestelling(items, bestellingNr, status, besteld);
        }

        List<Bestelling> HaalAllenBestellingen()
        {
            return _context.HaalAllenBestellingen();
        }

        List<Bestelling> HaalBestellingenVanKlant(int klantNr)
        {
            return _context.HaalBestellingenVanKlant(klantNr);
        }
    }
}
