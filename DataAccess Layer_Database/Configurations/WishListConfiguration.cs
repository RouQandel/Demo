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
    public class WishListConfiguration : IEntityTypeConfiguration<WishList>
    {
        public void Configure(EntityTypeBuilder<WishList> builder)
        {
            builder.HasKey(w => w.Id);
            builder.Property(w => w.CreateDate).IsRequired();

            builder.HasOne(w => w.Courses)
                   .WithMany(c => c.wishLists);

            //builder.HasOne(w => w.user)
            //       .WithOne(u => u.WishList)
            //       .HasForeignKey<WishList>(w => w.UserId);
        }
    }

}
