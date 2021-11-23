using System;
using System.Collections.Generic;
using System.Text;

namespace ManagementRestaurant.Data.Entities
{
    public class IngredientInOrder
    {
        public int OrderIngredientId { get; set; }

        public OrderIngredient OrderIngredient { get; set; }

        public int IngredientId { get; set; }

        public Ingredient Ingredient { get; set; }
    }
}
