using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivePerformance.DataAccesLayer.ContextInterfaces;

namespace LivePerformance.DataAccesLayer.Repository
{
    class AdresRepo
    {
        private readonly IAdresContext _context;
        bool MaakAdres(string straat, int huisNummer, string woonplaats)
        {
            return _context.MaakAdres(straat, huisNummer, woonplaats);
        }
        List<Adres> HaalAdressenVanKlant(int klantNr)
        {
            return _context.HaalAdressenVanKlant(klantNr);
        }

        List<Adres> HaalAllenAdressen()
        {
            return _context.HaalAllenAdressen();
        }
    }
}
