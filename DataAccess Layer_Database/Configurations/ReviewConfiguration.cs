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
    public class ReviewConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            //builder.HasKey(r => r.ReviewId);
            //builder.Property(r => r.Comment).HasMaxLength(500).IsRequired();
            //builder.Property(r => r.Rating).IsRequired();
            //builder.Property(r => r.ReviewDate).IsRequired();

           
            //builder.HasOne(r => r.user)
            //       .WithMany(u => u.reviews)
            //       .HasForeignKey(r => r.UserId);
        }
    }

}
