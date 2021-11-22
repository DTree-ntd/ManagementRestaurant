using ManagementRestaurant.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManagementRestaurant.Data.Configurations
{
    internal class IngredientInProductConfiguration : IEntityTypeConfiguration<IngredientInProduct>
    {
        public void Configure(EntityTypeBuilder<IngredientInProduct> builder)
        {
            builder.HasKey(t => new { t.IngredientId, t.ProductId });

            builder.ToTable("IngredientInProducts");

            builder.HasOne(t => t.Product).WithMany(ip => ip.IngredientInProducts)
                .HasForeignKey(ip => ip.ProductId);

            builder.HasOne(t => t.Ingredient).WithMany(ip => ip.IngredientInProducts)
              .HasForeignKey(ip => ip.IngredientId);
        }
    }
}
