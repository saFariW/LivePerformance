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
        public int PizzaNr { get; set; }
        public Vorm Vorm { get; set; }
        public decimal Oppervlak { get; set; }
        public string Formaat { get; set; }

        public Pizza(Bodem bodem, int pizzaNr, Vorm vorm, decimal oppervlak, string formaat)
        {
            Bodem = bodem;
            PizzaNr = pizzaNr;
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
