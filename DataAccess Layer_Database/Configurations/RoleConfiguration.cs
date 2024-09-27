﻿using DataAccess_Layer_Database.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Emit;

namespace DataAccess_Layer_Database.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Description).HasMaxLength(250);

            
            builder.HasMany<User>()
                   .WithOne(u => u.UserRole)
                   .HasForeignKey(u => u.RoleId);
           
        }
    }

}
