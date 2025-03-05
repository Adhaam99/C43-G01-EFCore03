using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assignment.ConfigurationModels
{
    public class Course_InstConfigurationModel : IEntityTypeConfiguration<Course_Inst>
    {
        public void Configure(EntityTypeBuilder<Course_Inst> builder)
        {
            builder.HasKey(CI => new { CI.Course_ID, CI.Inst_ID });

            builder.HasOne(CI => CI.Course)
                .WithMany(C => C.Course_Insts)
                .HasForeignKey(CI => CI.Course_ID)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(CI => CI.Instructor)
                   .WithMany(I => I.Course_Insts)
                   .HasForeignKey(CI => CI.Inst_ID)
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
