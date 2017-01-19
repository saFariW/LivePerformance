using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivePerformance.Items;

namespace LivePerformance
{
    class Pizzaria
    {
        public List<Klant> Klanten { get; set; }   
        public List<Adres> Adresen { get; set; }
        public List<Ingredient> Ingredienten { get; set; }
        public List<Bodem> Bodems { get; set; } 
        public List<Pizza> Pizzas { get; set; }
        public List<Product> Producten { get; set; }
        public List<Bestelling> Bestellingen { get; set; }

    }
}
