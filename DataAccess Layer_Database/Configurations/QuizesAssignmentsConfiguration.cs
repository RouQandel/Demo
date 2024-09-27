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
    public class QuizesAssignmentsConfiguration : IEntityTypeConfiguration<QuizesAssignments>
    {
        public void Configure(EntityTypeBuilder<QuizesAssignments> builder)
        {
            //builder.HasKey(q => q.Id);
            //builder.Property(q => q.Mark).IsRequired();
            //builder.Property(q => q.Title).HasMaxLength(100).IsRequired();

            //builder.HasOne(q => q.Courses)
            //       .WithMany(c => c.quizes);

            //builder.HasOne(q => q.user)
            //       .WithMany(u => u.quizes);
        }
    }

}
