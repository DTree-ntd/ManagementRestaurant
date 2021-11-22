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

        public decimal OriginalPrice { get; set; }

        public decimal Profit { get; set; }

        public decimal Price {
            get { return Price; }
            set { Price = OriginalPrice * (1 + Profit); }
        }

        public Status Status { get; set; } 

        public string Description { get; set; }

        public List<IngredientInProduct> IngredientInProducts { get; set; }

        public List<ProductInMenu> ProductInMenus { get; set; }
    }
}
