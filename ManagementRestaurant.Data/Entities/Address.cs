using System;
using System.Collections.Generic;
using System.Text;

namespace ManagementRestaurant.Data.Entities
{
    public class Address
    {
        public int Id { get; set; }

        public string AddressOne { get; set; }

        public string AddressTwo { get; set; }

        public string District { get; set; }

        public string City { get; set; }

        public int RestaurantID { get; set; }

        public Restaurant Restaurant { get; set; }
    }
}
