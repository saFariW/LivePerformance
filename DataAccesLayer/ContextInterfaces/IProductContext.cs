using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance.DataAccesLayer.ContextInterfaces
{
    interface IProductContext
    {
        List<Product> HaalAlleProducten();
    }
}
