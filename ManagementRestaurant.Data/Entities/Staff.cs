using ManagementRestaurant.Data.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManagementRestaurant.Data.Entities
{
    public class Staff : IdentityUser<Guid>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime Dob { get; set; }

        public string Phone { get; set; }

        public DateTime StartTime { get; set; }

        public Status Status { get; set; }

        public int RoleId { get; set; }

        public Role Role { get; set; }

        public int RestaurantId { get; set; }

        public Restaurant Restaurant { get; set; }

        public List<OrderIngredient> OrderIngredients { get; set;}

        public List<OrderProduct> OrderProducts { get; set; }
    }
}
