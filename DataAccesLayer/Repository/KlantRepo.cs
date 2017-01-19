using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivePerformance.DataAccesLayer.ContextInterfaces;

namespace LivePerformance.DataAccesLayer.Repository
{
    public class KlantRepo
    {
        private readonly IKlantContext _context;

        public KlantRepo(IKlantContext context)
        {
            _context = context;
        }

        bool MaakKlant(int adresNr, int klantNr, string email, string voorNaam, string tussenVoegsel, string achterNaam)
        {
            return _context.MaakKlant(adresNr, klantNr, email, voorNaam, tussenVoegsel, achterNaam);
        }

        public List<Klant> HaalAllenKlanten()
        {
            return _context.HaalAllenKlanten();
        }
    }
}
