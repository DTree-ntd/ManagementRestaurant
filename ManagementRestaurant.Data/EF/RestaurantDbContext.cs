using ManagementRestaurant.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManagementRestaurant.Data.EF
{
    public class RestaurantDbContext : DbContext
    {
        public RestaurantDbContext( DbContextOptions<RestaurantDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Ingredient> Ingredients { get; set; }

        public DbSet<Menu> Menus { get; set; }
    }
}
