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
            var QueryString =
                "SELECT DISTINCT t.ID, t.Remise_ID_Standplaats, tt.Omschrijving, t.Nummer, t.Lengte, t.Status, t.Vervuild, t.Defect, t.ConducteurGeschikt, t.Beschikbaar, min(tl.Lijn_ID) AS lijn_ID FROM TRAM as t FULL OUTER JOIN TRAMTYPE as tt on tt.ID = t.Tramtype_ID FULL OUTER JOIN TRAM_LIJN as tl on t.ID = tl.Tram_ID GROUP BY t.ID, t.Remise_ID_Standplaats, tt.Omschrijving, t.Nummer, t.Lengte, t.Status, t.Vervuild, t.Defect, t.ConducteurGeschikt, t.Beschikbaar";
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
            throw new NotImplementedException();
        }

        private static Ingredient MaakIngredientFromReader(SqlDataReader reader)
        {
            return new Ingredient(
                Convert.ToInt32(reader["IngredientNR"]),
                Convert.ToBoolean(reader["Halal"]),
                Convert.ToBoolean(reader["Vega"]));
        }
    }
}
