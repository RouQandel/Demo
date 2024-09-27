using DataAccess_Layer_Database.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer_Database.Configurations
{
    public class CertificatesConfiguration : IEntityTypeConfiguration<Certificates>
    {
        public void Configure(EntityTypeBuilder<Certificates> builder)
        {
            //builder.HasKey(c => c.Id);
            //builder.Property(c => c.IssuseDate).IsRequired();

            //// Navigation Properties
            //builder.HasOne(c => c.courses)
            //       .WithMany(course => course.Certificates)
            //       .HasForeignKey(c => c.Id);

            //builder.HasOne(c => c.user)
            //       .WithMany(u => u.certificates)
            //       .HasForeignKey(c => c.UserId);
        }
    }

}
