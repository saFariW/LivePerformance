using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivePerformance.DataAccesLayer.ContextInterfaces;
using LivePerformance.Items;

namespace LivePerformance.DataAccesLayer.SQLContext
{
    class PizzaSql : IPizzaContext
    {
        public bool MaakPizza(Bodem bodem, int pizzaNr, Vorm vorm, decimal oppervlak, string formaat)
        {
            throw new NotImplementedException();
        }

        public bool MaakPizzaStandaard(Bodem bodem, int pizzaNr, Vorm vorm, decimal oppervlak, string formaat)
        {
            throw new NotImplementedException();
        }

        public List<Pizza> HaalTop3MeestBesteldePizzas()
        {
            throw new NotImplementedException();
        }

        public List<Pizza> HaalStandaardPizzas()
        {
            throw new NotImplementedException();
        }
    }
}
