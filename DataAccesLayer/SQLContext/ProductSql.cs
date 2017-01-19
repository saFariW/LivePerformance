using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivePerformance.DataAccesLayer.ContextInterfaces;
using LivePerformance.Items;

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
            var producten = new List<Product>();
            var QueryString = "select * from INGREDIENT";
            using (var conn = new SqlConnection(_connString))
            {
                using (var cmd = new SqlCommand(QueryString, conn))
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            producten.Add(MaakProductFromReader(reader));
                        }
                        return producten;
                    }
                }
            }
            return null;
        }

        private static Product MaakProductFromReader(SqlDataReader reader)
        {
            return new Product(
                Convert.ToInt32(reader["ProductNR"]),
                Convert.ToString(reader["Omschrijving"]),
                Convert.ToDecimal(reader["Kprijs"]),
                Convert.ToDecimal(reader["VPrijs"]),
                Convert.ToBoolean(reader["Alcohol"]));
        }
    }
}
