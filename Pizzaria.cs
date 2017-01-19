using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivePerformance.DataAccesLayer.Repository;
using LivePerformance.DataAccesLayer.SQLContext;
using LivePerformance.Items;

namespace LivePerformance
{
    public class Pizzaria
    {
        private readonly AdresRepo _adresRepo;
        private readonly BestellingRepo _bestellingRepo;
        private readonly BodemRepo _bodemRepo;
        private readonly IngredientRepo _ingredientRepo;
        private readonly KlantRepo _klantRepo;
        private readonly PizzaRepo _pizzaRepo;
        private readonly ProductRepo _productRepo;

        public List<Klant> Klanten { get; set; }
        public List<Adres> Adresen { get; set; }
        public List<Ingredient> Ingredienten { get; set; }
        public List<Bodem> Bodems { get; set; }
        public List<Pizza> Pizzas { get; set; }
        public List<Product> Producten { get; set; }
        public List<Bestelling> Bestellingen { get; set; }
        public Bestelling Bestelling { get; set; }

        public Pizzaria()
        {
            _adresRepo = new AdresRepo(new AdresSql());
            _bestellingRepo = new BestellingRepo(new BestellingSql());
            _bodemRepo = new BodemRepo(new BodemSql());
            _ingredientRepo = new IngredientRepo(new IngredientSql());
            _klantRepo = new KlantRepo(new KlantSql());
            _pizzaRepo = new PizzaRepo(new PizzaSql());
            _productRepo = new ProductRepo(new ProductSql());

            try
            {
                _productRepo.HaalAlleProducten();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("het ophalen van de producten tijdens het opstarten ging fout : " + ex.Message);
                throw;
            }
        }
    }
}
