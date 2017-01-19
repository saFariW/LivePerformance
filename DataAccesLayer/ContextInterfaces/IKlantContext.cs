using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance.DataAccesLayer.ContextInterfaces
{
    interface IKlantContext
    {
        bool MaakKlant(int adresNr, int klantNr, string email, string voorNaam, string tussenVoegsel, string achterNaam)
        List<Klant> HaalAllenKlanten();
    }
}
