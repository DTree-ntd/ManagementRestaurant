using ManagementRestaurant.Data.Entities;
using ManagementRestaurant.Data.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManagementRestaurant.Data.Configurations
{
    public class OrderProductConfiguration : IEntityTypeConfiguration<OrderProduct>
    {
        public void Configure(EntityTypeBuilder<OrderProduct> builder)
        {
            builder.ToTable("OrderProducts");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.OrderStatus).IsRequired().HasDefaultValue(OrderStatus.InProgress);

            builder.HasOne(x => x.Staff).WithMany(x => x.OrderProducts).HasForeignKey(x => x.StaffId);
        }
    }
}
