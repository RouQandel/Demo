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
    public class CoursesConfiguration : IEntityTypeConfiguration<Courses>
    {
        public void Configure(EntityTypeBuilder<Courses> builder)
        {
            //builder.HasKey(c => c.CoursesId);
            //builder.Property(c => c.Price).IsRequired();
            //builder.Property(c => c.InstrctorName).HasMaxLength(100).IsRequired();
            //builder.Property(c => c.Content).IsRequired();
            //builder.Property(c => c.Description).HasMaxLength(500).IsRequired();
            //builder.Property(c => c.Title).HasMaxLength(150).IsRequired();

            ////Navigation Properties
            //builder.HasOne(c => c.Instructor) 
            //       .WithMany(u => u.courses)
            //       .HasForeignKey(c => c.UserId);

            //builder.HasMany(c => c.categories)
            //       .WithMany(cat => cat.Courses);

            //builder.HasMany(c => c.Enrollments)
            //       .WithOne(e => e.courses);

            //builder.HasMany(c => c.payments)
            //       .WithOne(p => p.Courses);

            //builder.HasMany(c => c.Certificates)
            //       .WithOne(cert => cert.courses);

            //builder.HasMany(c => c.quizes)
            //       .WithOne(q => q.Courses);
        }
    }

}
