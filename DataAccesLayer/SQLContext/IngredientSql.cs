using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivePerformance.DataAccesLayer.ContextInterfaces;
using LivePerformance.Items;

namespace LivePerformance.DataAccesLayer.SQLContext
{
    class IngredientSql : IIngredientContext
    {
        private string ConnString;
        public IngredientSql()
        {
            Connection connection = new Connection();
            ConnString = connection.ConnectionString;
        }

        public List<Ingredient> HaalAllenIngredienten()
        {
            var ingredienten = new List<Ingredient>();
            var QueryString ="select * from INGREDIENT";
            using (var conn = new SqlConnection(ConnString))
            {
                using (var cmd = new SqlCommand(QueryString, conn))
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ingredienten.Add(MaakIngredientFromReader(reader));
                        }
                        return ingredienten;
                    }
                }
            }
            return null;
        }

        private static Ingredient MaakIngredientFromReader(SqlDataReader reader)
        {
            return new Ingredient(
                Convert.ToInt32(reader["IngredientNR"]),
                Convert.ToString(reader["Omschrijving"]),
                Convert.ToDecimal(reader["Kprijs"]),
                Convert.ToDecimal(reader["VPrijs"]),
                Convert.ToBoolean(reader["Halal"]),
                Convert.ToBoolean(reader["Vega"]));
        }
    }
}
