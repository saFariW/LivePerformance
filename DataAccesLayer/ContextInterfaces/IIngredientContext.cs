using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivePerformance.Items;

namespace LivePerformance.DataAccesLayer.ContextInterfaces
{
    public interface IIngredientContext
    {
        List<Ingredient> HaalAllenIngredienten();
    }
}
