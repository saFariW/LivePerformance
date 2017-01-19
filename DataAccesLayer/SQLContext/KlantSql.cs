using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivePerformance.DataAccesLayer.ContextInterfaces;

namespace LivePerformance.DataAccesLayer.SQLContext
{
    class KlantSql : IKlantContext
    {
        public bool MaakKlant(int adresNr, int klantNr, string email, string voorNaam, string tussenVoegsel, string achterNaam)
        {
            throw new NotImplementedException();
        }

        public List<Klant> HaalAllenKlanten()
        {
            throw new NotImplementedException();
        }
    }
}
