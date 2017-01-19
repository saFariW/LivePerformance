using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance.Items
{
    class Pizza : Item
    {
        public Bodem Bodem { get; set; }
        public Vorm Vorm { get; set; }
        public decimal Oppervlak { get; set; }
        public string Formaat { get; set; }
        
        public Pizza(Bodem bodem, Vorm vorm, decimal oppervlak, string formaat, int artikkelNr, string beschrijving, decimal kPrijs, decimal vPrijs) : base(artikkelNr, beschrijving, kPrijs, vPrijs)
        {
            Bodem = bodem;
            Vorm = vorm;
            Oppervlak = oppervlak;
            Formaat = formaat;
        }

        public decimal BerekenPrijs()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
