using ManagementRestaurant.Data.Configurations;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new IngredientConfiguration());

            modelBuilder.ApplyConfiguration(new ProductConfiguration());

            modelBuilder.ApplyConfiguration(new MenuConfiguration());

            modelBuilder.ApplyConfiguration(new IngredientInProductConfiguration());

            modelBuilder.ApplyConfiguration(new ProductInMenuConfiguration());

            // base.OnModelCreating(modelBuilder);
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Ingredient> Ingredients { get; set; }

        public DbSet<Menu> Menus { get; set; }

        public DbSet<IngredientInProduct> IngredientInProducts { get; set; }

        public DbSet<ProductInMenu> ProductInMenus { get; set; }
    }
}
