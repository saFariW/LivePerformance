using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivePerformance.DataAccesLayer.ContextInterfaces;

namespace LivePerformance.DataAccesLayer.SQLContext
{
    class BestellingSql :IBestellingContext
    {
        private string _connString;
        public BestellingSql()
        {
            Connection connection = new Connection();
            _connString = connection.ConnectionString;
        }

        public bool MaakBestelling(List<Item> items, int bestellingNr, Status status, DateTime besteld)
        {
            throw new NotImplementedException();
        }

        public List<Bestelling> HaalAllenBestellingen()
        {
            throw new NotImplementedException();
        }

        public List<Bestelling> HaalBestellingenVanKlant(int klantNr)
        {
            throw new NotImplementedException();
        }
    }
}
