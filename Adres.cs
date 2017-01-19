using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance
{
    public class Adres
    {
        public int AdresNr { get; set; }
        public string Straat { get; set; }
        public int HuisNummer { get; set; }
        public string Woonplaats { get; set; }

        public Adres(int adresNr, string straat, int huisNummer, string woonplaats)
        {
            AdresNr = adresNr;
            Straat = straat;
            HuisNummer = huisNummer;
            Woonplaats = woonplaats;
        }

        public Adres(string straat, int huisNummer, string woonplaats)
        {
            Straat = straat;
            HuisNummer = huisNummer;
            Woonplaats = woonplaats;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
