using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivePerformance.DataAccesLayer.ContextInterfaces;

namespace LivePerformance.DataAccesLayer.SQLContext
{
    class BestellingSql :IBestellingContext
    {
        private string _connString;
        public BestellingSql()
        {
            Connection connection = new Connection();
            _connString = connection.ConnectionString;
        }

        public bool MaakBestelling(List<Item> items, int bestellingNr, Status status, DateTime besteld)
        {
            //https://stackoverflow.com/questions/7097079/c-sharp-sql-server-passing-a-list-to-a-stored-procedure
            using (var conn = new SqlConnection(_connString))
            {
                try
                {
                    using (var cmd = new SqlCommand("MaakBestelling", conn))
                    {
                        conn.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@seatings", bestellingNr));
                        cmd.Parameters.Add(new SqlParameter("@rows", status));
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (SqlException e)
                {
                    Debug.WriteLine(e.Message);
                    return false;
                }
            }
        }

        public List<Bestelling> HaalAllenBestellingen()
        {
            throw new NotImplementedException();
        }

        public List<Bestelling> HaalBestellingenVanKlant(int klantNr)
        {
            throw new NotImplementedException();
        }
    }
}
