using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivePerformance.DataAccesLayer.ContextInterfaces;
using LivePerformance.Items;

namespace LivePerformance.DataAccesLayer.Repository
{
    class BodemRepo
    {
        private readonly IBodemContext _context;

        List<Bodem> HaalAllenBodems()
        {
            return _context.HaalAllenBodems();
        }
    }
}
