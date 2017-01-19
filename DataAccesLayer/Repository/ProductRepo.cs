using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivePerformance.DataAccesLayer.ContextInterfaces;

namespace LivePerformance.DataAccesLayer.Repository
{
    class ProductRepo
    {
        private readonly IProductContext _context;

        List<Product> HaalAlleProducten()
        {
            return _context.HaalAlleProducten();
        }
    }
}
