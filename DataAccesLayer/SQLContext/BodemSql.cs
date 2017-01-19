using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivePerformance.DataAccesLayer.ContextInterfaces;
using LivePerformance.Items;

namespace LivePerformance.DataAccesLayer.SQLContext
{
    class BodemSql : IBodemContext
    {
        private string _connString;

        public BodemSql()
        {
            Connection connection = new Connection();
            _connString = connection.ConnectionString;
        }

        public List<Bodem> HaalAllenBodems()
        {
            throw new NotImplementedException();
        }
    }
}
