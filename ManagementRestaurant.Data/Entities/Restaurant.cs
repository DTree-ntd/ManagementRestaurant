using ManagementRestaurant.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManagementRestaurant.Data.Entities
{
    public class Restaurant
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Status Status { get; set; }

        public List<MenuInRestaurant> MenuInRestaurants { get; set; }

        public Address Address { get; set; }

        public List<Staff> Staffs { get; set; }
    }
}
