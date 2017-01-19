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
        private string _connString;
        public AdresSql()
        {
            Connection connection = new Connection();
            _connString = connection.ConnectionString;
        }

        public bool MaakAdres(string straat, int huisNummer, string woonplaats)
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
