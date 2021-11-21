using ManagementRestaurant.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManagementRestaurant.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public decimal OriginalPrice { get; set; }

        public decimal Profit { get; set; }

        public int IngredientId { get; set; }

        public Status Status { get; set; } 

        public string Description { get; set; }
    }
}
