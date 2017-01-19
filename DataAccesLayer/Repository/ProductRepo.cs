using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivePerformance.DataAccesLayer.ContextInterfaces;

namespace LivePerformance.DataAccesLayer.Repository
{
    public class ProductRepo
    {
        private readonly IProductContext _context;

        public ProductRepo(IProductContext context)
        {
            _context = context;
        }

        List<Product> HaalAlleProducten()
        {
            return _context.HaalAlleProducten();
        }
    }
}
