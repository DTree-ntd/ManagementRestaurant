using ManagementRestaurant.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManagementRestaurant.Data.Configurations
{
    public class IngredientInOrderConfiguration : IEntityTypeConfiguration<IngredientInOrder>
    {
        public void Configure(EntityTypeBuilder<IngredientInOrder> builder)
        {
            builder.HasKey(t => new { t.IngredientId, t.OrderIngredientId });

            builder.ToTable("IngredientInOrders");

            builder.HasOne(t => t.OrderIngredient).WithMany(ip => ip.IngredientInOrders)
                .HasForeignKey(ip => ip.OrderIngredientId);

            builder.HasOne(t => t.Ingredient).WithMany(ip => ip.IngredientInOrders)
              .HasForeignKey(ip => ip.IngredientId);
        }
    }
}
