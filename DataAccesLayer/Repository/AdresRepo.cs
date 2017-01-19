using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivePerformance.DataAccesLayer.ContextInterfaces;

namespace LivePerformance.DataAccesLayer.Repository
{
    public class AdresRepo
    {
        private readonly IAdresContext _context;

        public AdresRepo(IAdresContext context)
        {
            _context = context;
        }

        public bool MaakAdres(string straat, int huisNummer, string woonplaats)
        {
            return _context.MaakAdres(straat, huisNummer, woonplaats);
        }
        public List<Adres> HaalAdressenVanKlant(int klantNr)
        {
            return _context.HaalAdressenVanKlant(klantNr);
        }

        public List<Adres> HaalAllenAdressen()
        {
            return _context.HaalAllenAdressen();
        }
    }
}
