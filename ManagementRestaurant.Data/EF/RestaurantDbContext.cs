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
            modelBuilder.ApplyConfiguration(new AddressConfiguration());

            modelBuilder.ApplyConfiguration(new IngredientConfiguration());

            modelBuilder.ApplyConfiguration(new IngredientInProductConfiguration());

            modelBuilder.ApplyConfiguration(new IngredientInOrderConfiguration());

            modelBuilder.ApplyConfiguration(new MenuConfiguration());

            modelBuilder.ApplyConfiguration(new MenuInRestaurantConfiguration());

            modelBuilder.ApplyConfiguration(new OrderIngredientConfiguration());

            modelBuilder.ApplyConfiguration(new OrderProductConfiguration());

            modelBuilder.ApplyConfiguration(new ProductConfiguration());

            modelBuilder.ApplyConfiguration(new ProductInMenuConfiguration());

            modelBuilder.ApplyConfiguration(new ProductInOrderConfiguration());

            modelBuilder.ApplyConfiguration(new RestaurantConfiguration());

            modelBuilder.ApplyConfiguration(new RoleConfiguration());

            modelBuilder.ApplyConfiguration(new StaffConfiguration());

            // base.OnModelCreating(modelBuilder);
        }

        public DbSet<Address> Address { get; set; }

        public DbSet<Ingredient> Ingredients { get; set; }

        public DbSet<IngredientInOrder> IngredientInOrders { get; set; }

        public DbSet<IngredientInProduct> IngredientInProducts { get; set; }

        public DbSet<Menu> Menus { get; set; }

        public DbSet<MenuInRestaurant> MenuInRestaurants { get; set; }

        public DbSet<OrderProduct> OrderProducts { get; set; }

        public DbSet<OrderIngredient> OrderIngredients { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductInMenu> ProductInMenus { get; set; }

        public DbSet<ProductInOrder> ProductInOrders { get; set; }

        public DbSet<Restaurant> Restaurants { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<Staff> Staffs { get; set; }
    }
}
