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
    class InstructorModelConfiguration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.HasOne( I => I.Department)
                .WithMany(D => D.Instructors)
                .HasForeignKey(I => I.Dep_ID)
                .IsRequired();

            builder.HasMany(I => I.Course_Insts)
                .WithOne(CI => CI.Instructor)
                .HasForeignKey(CI => CI.Inst_ID)
                .IsRequired();
        }
    }
}
