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
    public class EnrollmentConfiguration : IEntityTypeConfiguration<Enrollments>
    {
        public void Configure(EntityTypeBuilder<Enrollments> builder)
        {
        //    builder.HasKey(e => e.Id);
        //    builder.Property(e => e.IsCompletion).IsRequired();
        //    builder.Property(e => e.Date).IsRequired();

        //    // Navigation Property
   
        //builder.HasOne(e => e.courses)
        //           .WithMany(c => c.Enrollments)
        //           .HasForeignKey(e => e.Id);

        //    builder.HasOne(e => e.user)
        //           .WithMany(u => u.enrollments)
        //           .HasForeignKey(e => e.UserId);
        }
    }

}
