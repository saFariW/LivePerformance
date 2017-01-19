using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivePerformance.DataAccesLayer.ContextInterfaces;

namespace LivePerformance.DataAccesLayer.SQLContext
{
    class AdresSql : IAdresContext
    {
        public bool MaakAdres(string category)
        {
            throw new NotImplementedException();
        }

        public List<Adres> HaalAdressenVanKlant(int klantNr)
        {
            throw new NotImplementedException();
        }

        public List<Adres> HaalAllenAdressen()
        {
            throw new NotImplementedException();
        }
    }
}
