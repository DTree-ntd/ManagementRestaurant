using ManagementRestaurant.Data.Entities;
using ManagementRestaurant.Data.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManagementRestaurant.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).IsRequired().IsUnicode();

            builder.Property(x => x.OriginalPrice).IsRequired();

            builder.Property(x => x.Profit).IsRequired().HasDefaultValue(0.1);

            builder.Property(x => x.Status).IsRequired().HasDefaultValue(Status.Active);
        }
    }
}
