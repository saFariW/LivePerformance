﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance
{
    public abstract class Item : IComparable<Item>
    {
        public int ArtikkelNr { get; set; }
        public string Beschrijving { get; set; }
        public decimal KPrijs { get; set; }
        public decimal VPrijs { get; set; }

        protected Item(int artikkelNr, string beschrijving, decimal kPrijs, decimal vPrijs)
        {
            ArtikkelNr = artikkelNr;
            Beschrijving = beschrijving;
            KPrijs = kPrijs;
            VPrijs = vPrijs;
        }

        protected Item()
        {
        }

        public int CompareTo(Item other)
        {
            return Beschrijving.CompareTo(other.Beschrijving);
        }

        public override string ToString()
        {
            return ArtikkelNr + " : " + Beschrijving + "     EURO : " + VPrijs;
        }
    }
}
