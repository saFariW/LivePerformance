﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivePerformance.DataAccesLayer.ContextInterfaces;
using LivePerformance.Items;

namespace LivePerformance.DataAccesLayer.Repository
{
    public  class PizzaRepo
    {
        private readonly IPizzaContext _context;

        public PizzaRepo(IPizzaContext context)
        {
            _context = context;
        }

        public bool MaakPizza(Bodem bodem, int pizzaNr, Vorm vorm, decimal oppervlak, string formaat)
        {
            return _context.MaakPizza(bodem, pizzaNr, vorm, oppervlak, formaat);
        }

        public bool MaakPizzaStandaard(Bodem bodem, int pizzaNr, Vorm vorm, decimal oppervlak, string formaat)
        {
            return _context.MaakPizzaStandaard(bodem, pizzaNr, vorm, oppervlak, formaat);
        }

        public List<Pizza> HaalTop3MeestBesteldePizzas()
        {
            return _context.HaalTop3MeestBesteldePizzas();  
        }

        public List<Pizza> HaalStandaardPizzas()
        {
            return _context.HaalStandaardPizzas();
        }
    }
}
