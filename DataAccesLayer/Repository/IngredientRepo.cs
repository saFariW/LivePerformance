using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivePerformance.DataAccesLayer.ContextInterfaces;
using LivePerformance.Items;

namespace LivePerformance.DataAccesLayer.Repository
{
    class IngredientRepo
    {
        private readonly IIngredientContext _context;

        List<Ingredient> HaalAllenIngredienten()
        {
            return _context.HaalAllenIngredienten();
        }
    }
}
