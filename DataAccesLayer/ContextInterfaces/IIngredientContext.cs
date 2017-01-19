using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivePerformance.Items;

namespace LivePerformance.DataAccesLayer.ContextInterfaces
{
    interface IIngredientContext
    {
        List<Ingredient> HaalAllenIngredienten();
    }
}
