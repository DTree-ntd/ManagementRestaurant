using ManagementRestaurant.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManagementRestaurant.Data.Configurations
{
    public class ProductInOrderConfiguration : IEntityTypeConfiguration<ProductInOrder>
    {
        public void Configure(EntityTypeBuilder<ProductInOrder> builder)
        {
            builder.HasKey(t => new { t.OrderProductId, t.ProductId });

            builder.ToTable("ProductInOrders");

            builder.HasOne(t => t.Product).WithMany(pm => pm.ProductInOrders)
                .HasForeignKey(pm => pm.ProductId);

            builder.HasOne(t => t.OrderProduct).WithMany(pm => pm.ProductInOrders)
              .HasForeignKey(pm => pm.OrderProductId);
        }
    }
}
