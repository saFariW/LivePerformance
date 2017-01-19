using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivePerformance.DataAccesLayer.ContextInterfaces;
using LivePerformance.Items;

namespace LivePerformance.DataAccesLayer.Repository
{
    public class IngredientRepo
    {
        private readonly IIngredientContext _context;

        public IngredientRepo(IIngredientContext context)
        {
            _context = context;
        }

        public List<Ingredient> HaalAllenIngredienten()
        {
            return _context.HaalAllenIngredienten();
        }
    }
}
