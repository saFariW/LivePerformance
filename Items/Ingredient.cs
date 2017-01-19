using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance.Items
{
    class Ingredient : Item
    {
        public int IngredientNr { get; set; }
        public bool Halal { get; set; }
        public bool Vega { get; set; }

        public Ingredient(int ingredientNr, bool halal, bool vega)
        {
            IngredientNr = ingredientNr;
            Halal = halal;
            Vega = vega;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
