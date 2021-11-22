using System;
using System.Collections.Generic;
using System.Text;

namespace ManagementRestaurant.Data.Entities
{
    public class ProductInMenu
    {
        public int MenuId { get; set; }

        public Menu Menu { get; set; }

        public int ProductId { get; set; }

        public Product Product { get; set; }
    }
}
