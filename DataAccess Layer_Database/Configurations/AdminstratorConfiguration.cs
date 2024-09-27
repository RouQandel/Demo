using DataAccess_Layer_Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer_Database.Configurations
{
    public class AdminstratorConfiguration : IEntityTypeConfiguration<Adminstrator>
    {
        public void Configure(EntityTypeBuilder<Adminstrator> builder)
        {
            //builder.HasKey(a => a.AdminId);
            //builder.Property(a => a.AdminName).IsRequired().HasMaxLength(100);
            //builder.Property(a => a.AdminPassword).IsRequired().HasMaxLength(255);
            //builder.Property(a => a.AdminEmail).IsRequired().HasMaxLength(150);
            //builder.HasMany(a => a.Users)
            //  .WithOne(u => u.Adminstrator)
            //  .HasForeignKey(u => u.AdminId);
        }
    }
}
