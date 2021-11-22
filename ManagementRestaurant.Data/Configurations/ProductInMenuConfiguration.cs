using ManagementRestaurant.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManagementRestaurant.Data.Configurations
{
    public class ProductInMenuConfiguration : IEntityTypeConfiguration<ProductInMenu>
    {
        public void Configure(EntityTypeBuilder<ProductInMenu> builder)
        {
            builder.HasKey(t => new { t.MenuId, t.ProductId });

            builder.ToTable("ProductInMenus");

            builder.HasOne(t => t.Product).WithMany(pm => pm.ProductInMenus)
                .HasForeignKey(pm => pm.ProductId);

            builder.HasOne(t => t.Menu).WithMany(pm => pm.ProductInMenus)
              .HasForeignKey(pm => pm.MenuId);
        }
    }
}
