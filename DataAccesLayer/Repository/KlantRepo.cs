using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivePerformance.DataAccesLayer.ContextInterfaces;

namespace LivePerformance.DataAccesLayer.Repository
{
    class KlantRepo
    {
        private readonly IKlantContext _context;

        bool MaakKlant(int adresNr, int klantNr, string email, string voorNaam, string tussenVoegsel, string achterNaam)
        {
            return _context.MaakKlant(adresNr, klantNr, email, voorNaam, tussenVoegsel, achterNaam);
        }

        List<Klant> HaalAllenKlanten()
        {
            return _context.HaalAllenKlanten();
        }
    }
}
