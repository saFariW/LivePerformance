using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance
{
    public class Klant
    {
        public Adres Adres { get; set; }
        public int KlantNr { get; set; }
        public string Email { get; set; }
        public string VoorNaam { get; set; }
        public string TussenVoegsel { get; set; }
        public string AchterNaam { get; set; }

        public Klant(Adres adres, int klantNr, string email, string voorNaam, string tussenVoegsel, string achterNaam)
        {
            Adres = adres;
            KlantNr = klantNr;
            Email = email;
            VoorNaam = voorNaam;
            TussenVoegsel = tussenVoegsel;
            AchterNaam = achterNaam;
        }

        public Klant(Adres adres, string email, string voorNaam, string tussenVoegsel, string achterNaam)
        {
            Adres = adres;
            Email = email;
            VoorNaam = voorNaam;
            TussenVoegsel = tussenVoegsel;
            AchterNaam = achterNaam;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
