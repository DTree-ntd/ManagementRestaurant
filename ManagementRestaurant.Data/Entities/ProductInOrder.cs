using System;
using System.Collections.Generic;
using System.Text;

namespace ManagementRestaurant.Data.Entities
{
    public class ProductInOrder
    {
        public int OrderProductId { get; set; }

        public OrderProduct OrderProduct { get; set; }

        public int ProductId { get; set; }

        public Product Product { get; set; }
    }
}
