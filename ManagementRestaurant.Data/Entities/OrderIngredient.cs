using ManagementRestaurant.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManagementRestaurant.Data.Entities
{
    public class OrderIngredient
    {
        public int Id { get; set; }

        public decimal Price { get; set; }

        public OrderStatus OrderStatus { get; set; }

        public DateTime CreatedDate { get; set; }

        public List<IngredientInOrder> IngredientInOrders { get; set; }

        public Guid StaffId { get; set; }

        public Staff Staff { get; set; }
    }
}
