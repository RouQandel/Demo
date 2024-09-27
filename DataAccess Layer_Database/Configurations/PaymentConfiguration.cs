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
    public class PaymentConfiguration : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            //builder.HasKey(p => p.Id);
            //builder.Property(p => p.Method).HasMaxLength(50).IsRequired();
            //builder.Property(p => p.Amount).IsRequired();
            //builder.Property(p => p.PaymentDate).IsRequired();

            //builder.HasMany(p => p.users)
            //       .WithMany(u => u.payments);

            //builder.HasOne(p => p.Courses)
            //       .WithMany(c => c.payments);
        }
    }
}
