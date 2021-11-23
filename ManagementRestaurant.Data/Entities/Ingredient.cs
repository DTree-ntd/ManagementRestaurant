using System;
using System.Collections.Generic;
using System.Text;

namespace ManagementRestaurant.Data.Entities
{
    public class Ingredient
    {
        public int Id { get; set; }

        public string Name { get; set; }
        
        public decimal Price { get; set; }

        public int Stock { get; set; }

        public int ViewCount { get; set; }

        public DateTime DateImported { get; set; }

        public DateTime ExpirationDate { get; set; }

        public List<IngredientInProduct> IngredientInProducts { get; set;}

        public List<IngredientInOrder> IngredientInOrders { get; set; }
    }
}
