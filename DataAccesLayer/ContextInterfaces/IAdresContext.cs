using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivePerformance.Items;

namespace LivePerformance.DataAccesLayer.ContextInterfaces
{
    interface IAdresContext
    {
        bool MaakAdres(string straat, int huisNummer, string woonplaats);
        List<Adres> HaalAdressenVanKlant(int klantNr);
        List<Adres> HaalAllenAdressen();
    }
}
