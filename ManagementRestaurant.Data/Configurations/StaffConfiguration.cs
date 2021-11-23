using ManagementRestaurant.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManagementRestaurant.Data.Configurations
{
    public class StaffConfiguration : IEntityTypeConfiguration<Staff>
    {
        public void Configure(EntityTypeBuilder<Staff> builder)
        {
            builder.ToTable("Staffs");

            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(200);

            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(200);

            builder.Property(x => x.Dob).IsRequired();

            builder.Property(x => x.Phone).IsRequired();

            builder.HasOne(x => x.Role).WithMany(x => x.Staffs).HasForeignKey(x => x.RoleId);

            builder.HasOne(x => x.Restaurant).WithMany(x => x.Staffs).HasForeignKey(x => x.RestaurantId);
        }
    }
}
