using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivePerformance.Items;

namespace LivePerformance
{
    public class Bestelling
    {
        public List<Item> Items { get; set; }
        public int BestellingNr { get; set; }
        public Status Status { get; set; }
        public DateTime Besteld { get; set; }

        public Bestelling(List<Item> items, int bestellingNr, Status status, DateTime besteld)
        {
            Items = items;
            BestellingNr = bestellingNr;
            Status = status;
            Besteld = besteld;
        }

        public Bestelling(List<Item> items, Status status, DateTime besteld)
        {
            Items = items;
            Status = status;
            Besteld = besteld;
        }

        public decimal BerekenPrijsEx()
        {
            decimal prijsExBtw = 0;
            foreach (var item in Items)
            {
                if (item is Pizza)
                {
                    Pizza pizza = (Pizza) item;
                    pizza.BerekenPrijs();
                    prijsExBtw += pizza.VPrijs;
                }
                else
                {
                    prijsExBtw += item.VPrijs;
                }
            }
            return prijsExBtw;
        }

        public decimal BerekenBtw()
        {
            decimal btw6 = (decimal)0.06; // 6 procent btw
            decimal btw21 = (decimal)0.21; // 21 procent btw

            decimal prijsBtw = 0;
            foreach (var item in Items)
            {
                if (item is Pizza)
                {
                    Pizza pizza = (Pizza)item;
                    pizza.BerekenPrijs();
                    prijsBtw += (pizza.VPrijs * btw6); 
                }else if(item is Product)
                {
                    Product product = (Product)item;
                    if (product.Alcohol)
                    {
                        prijsBtw += (product.VPrijs * btw21); 
                    }
                    else
                    {
                        prijsBtw += item.VPrijs * btw6;
                    }
                }
                else
                {
                    prijsBtw += item.VPrijs * btw6;
                }
            }
            return prijsBtw;
        }

        public void PrintBon(string bestandsLocatie, Klant klant)
        {
            var prijsEx = BerekenPrijsEx();
            var Btw = BerekenBtw();
            using (StreamWriter sw = new StreamWriter(bestandsLocatie))
            {
                sw.WriteLine("Pizzeria La Crosta Insapore");
                sw.WriteLine("Klantbon "+ klant.VoorNaam +" "+ klant.TussenVoegsel +" " + klant.AchterNaam);
                sw.WriteLine("");
                sw.WriteLine("Producten : ");
                foreach (var item in Items)
                {
                    sw.WriteLine(item.ToString());
                }
                sw.WriteLine("Prijs exclusief BTW: "+ prijsEx);
                sw.WriteLine("BTW bedrag: " + Btw);
                sw.WriteLine("         Te betalen bedrag: " + (Btw + prijsEx));
            }
        }
    }
}
