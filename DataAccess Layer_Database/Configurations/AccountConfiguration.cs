using DataAccess_Layer_Database.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer_Database
{
    public class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
            public void Configure(EntityTypeBuilder<Account> builder)
            {
                //builder.ToTable("Accounts");
                //builder.HasKey(a => a.AccountId);

                //builder.Property(a => a.AccountName).IsRequired().HasMaxLength(100);
                //builder.Property(a => a.AccountType).IsRequired().HasMaxLength(50);

                //builder.HasOne(a => a.user)
                //       .WithOne(u => u.account)
                //       .HasForeignKey<Account>(a => a.UserId);
            }
    }
}
