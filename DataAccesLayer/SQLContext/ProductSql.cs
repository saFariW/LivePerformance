using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivePerformance.DataAccesLayer.ContextInterfaces;

namespace LivePerformance.DataAccesLayer.SQLContext
{
    class ProductSql : IProductContext
    {
        private string _connString;

        public ProductSql()
        {
            Connection connection = new Connection();
            _connString = connection.ConnectionString;
        }

        public List<Product> HaalAlleProducten()
        {
            throw new NotImplementedException();
        }
    }
}
