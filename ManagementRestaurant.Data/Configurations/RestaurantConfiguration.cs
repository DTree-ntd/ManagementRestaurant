using ManagementRestaurant.Data.Entities;
using ManagementRestaurant.Data.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManagementRestaurant.Data.Configurations
{
    public class RestaurantConfiguration : IEntityTypeConfiguration<Restaurant>
    {
        public void Configure(EntityTypeBuilder<Restaurant> builder)
        {
            builder.ToTable("Restaurants");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).IsRequired().IsUnicode();

            builder.Property(x => x.Status).IsRequired().HasDefaultValue(Status.Active);

            builder.HasOne(a => a.Address).WithOne(ad => ad.Restaurant).HasForeignKey<Address>(x => x.RestaurantID);
        }
    }
}
