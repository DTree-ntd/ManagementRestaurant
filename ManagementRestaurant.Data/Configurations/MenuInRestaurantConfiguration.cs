using ManagementRestaurant.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManagementRestaurant.Data.Configurations
{
    public class MenuInRestaurantConfiguration : IEntityTypeConfiguration<MenuInRestaurant>
    {
        public void Configure(EntityTypeBuilder<MenuInRestaurant> builder)
        {
            builder.HasKey(t => new { t.MenuId, t.RestaurantId });

            builder.ToTable("MenuInRestaurants");

            builder.HasOne(t => t.Restaurant).WithMany(pm => pm.MenuInRestaurants)
                .HasForeignKey(pm => pm.RestaurantId);

            builder.HasOne(t => t.Menu).WithMany(pm => pm.MenuInRestaurants)
              .HasForeignKey(pm => pm.MenuId);
        }
    }
}
