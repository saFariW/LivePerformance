using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivePerformance.Items;

namespace LivePerformance.DataAccesLayer.ContextInterfaces
{
    public interface IPizzaContext
    {
        bool MaakPizza(Bodem bodem, int pizzaNr, Vorm vorm, decimal oppervlak, string formaat);
        bool MaakPizzaStandaard(Bodem bodem, int pizzaNr, Vorm vorm, decimal oppervlak, string formaat);
        List<Pizza> HaalTop3MeestBesteldePizzas();
        List<Pizza> HaalStandaardPizzas();
    }
}
