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
    class CourseModelConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasOne(C => C.Topic)
                .WithMany(T => T.Courses)
                .HasForeignKey(C => C.Top_ID);

            builder.HasMany(C => C.Stud_Courses)
                .WithOne(SC => SC.Course)
                .HasForeignKey(SC => SC.Course_ID)
                .IsRequired();

            builder.HasMany(C => C.Course_Insts)
                .WithOne(CI => CI.Course)
                .HasForeignKey(CI => CI.Course_ID)
                .IsRequired();
        }
    }
}
