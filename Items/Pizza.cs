using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance.Items
{
    public class Pizza : Item
    {
        public Bodem Bodem { get; set; }
        public List<Ingredient> Ingredienten { get; set; }  
        public Vorm Vorm { get; set; }
        public decimal Oppervlak { get; set; }
        public string Formaat { get; set; }
        
        public Pizza(Bodem bodem, List<Ingredient> ingredienten, Vorm vorm, decimal oppervlak, string formaat, int artikkelNr, string beschrijving, decimal kPrijs, decimal vPrijs) : base(artikkelNr, beschrijving, kPrijs, vPrijs)
        {
            Bodem = bodem;
            Ingredienten = ingredienten;
            Vorm = vorm;
            Oppervlak = oppervlak;
            Formaat = formaat;
        }

        public Pizza()
        {
        }

        public decimal BerekenOppervlakte(Vorm vorm, int Diameter, int lengte1, int lengte2, int lengte3)
        {
            switch (vorm)
            {
                case Vorm.Rond:
                    return (decimal)(0.25 * Math.PI * Math.Pow(Diameter, 2));
                case Vorm.Vierkant:
                    return lengte1*lengte2;
                case Vorm.Driehoek:
                    double tempVar = ((lengte1 + lengte2 + lengte3)/2);
                    return (decimal)Math.Sqrt(tempVar*(tempVar - lengte1)*(tempVar - lengte2)*(tempVar - lengte3));
                default:
                    Console.WriteLine("Berekenen Oppervlakte in Pizza.cs Ging fout."); // debug purposes
                    return -1;
            }
        }

        public decimal BerekenPrijs()
        {
            decimal toTaalVPrijs = Bodem.VPrijs;
            foreach (var ingredient in Ingredienten)
            {
                toTaalVPrijs += ingredient.VPrijs;
            }
            return VPrijs = Oppervlak*toTaalVPrijs;
        }

        public override string ToString()
        {
            return ArtikkelNr + " : " + Beschrijving + "     EURO : " + BerekenPrijs();
        }
    }
}
