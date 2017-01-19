using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivePerformance.DataAccesLayer.ContextInterfaces;
using LivePerformance.Items;

namespace LivePerformance.DataAccesLayer.Repository
{
    class PizzaRepo
    {
        private readonly IPizzaContext _context;

        bool MaakPizza(Bodem bodem, int pizzaNr, Vorm vorm, decimal oppervlak, string formaat)
        {
            return _context.MaakPizza(bodem, pizzaNr, vorm, oppervlak, formaat);
        }

        bool MaakPizzaStandaard(Bodem bodem, int pizzaNr, Vorm vorm, decimal oppervlak, string formaat)
        {
            return _context.MaakPizzaStandaard(bodem, pizzaNr, vorm, oppervlak, formaat);
        }

        List<Pizza> HaalTop3MeestBesteldePizzas()
        {
            return _context.HaalTop3MeestBesteldePizzas();  
        }

        List<Pizza> HaalStandaardPizzas()
        {
            return _context.HaalStandaardPizzas();
        }
    }
}
