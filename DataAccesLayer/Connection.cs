using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance.DataAccesLayer
{
    class Connection
    {
        public string ConnectionString { get; set; }
        public Connection()
        {
            // connection string
            ConnectionString = @"Data Source=SAFARIPC\SQLEXPRESS;Initial Catalog=LivePerformance;Integrated Security=True";
            //Server=mssql.fhict.local;Database=dbi344291;User Id=dbi344291;Password=MssqlSuperTofPasswordVoorLivePerformance;
        }
    }
}
