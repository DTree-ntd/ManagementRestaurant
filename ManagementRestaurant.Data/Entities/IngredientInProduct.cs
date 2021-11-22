using System;
using System.Collections.Generic;
using System.Text;

namespace ManagementRestaurant.Data.Entities
{
    public class IngredientInProduct
    {
        public int IngredientId { get; set; }

        public Ingredient Ingredient { get; set; }

        public int ProductId { get; set; }

        public Product Product { get; set; }
    }
}
