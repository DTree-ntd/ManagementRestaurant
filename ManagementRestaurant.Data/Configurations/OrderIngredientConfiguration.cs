using ManagementRestaurant.Data.Entities;
using ManagementRestaurant.Data.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManagementRestaurant.Data.Configurations
{
    public class OrderIngredientConfiguration : IEntityTypeConfiguration<OrderIngredient>
    {      

        public void Configure(EntityTypeBuilder<OrderIngredient> builder)
        {
            builder.ToTable("OrderIngredients");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.OrderStatus).IsRequired().HasDefaultValue(OrderStatus.InProgress);

            builder.HasOne(x => x.Staff).WithMany(x => x.OrderIngredients).HasForeignKey(x => x.StaffId);
        }
    }
}
