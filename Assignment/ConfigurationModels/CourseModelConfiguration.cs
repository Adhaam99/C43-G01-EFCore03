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
    public class CourseModelConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasOne(C => C.Topic)
                   .WithMany(T => T.Courses)
                   .HasForeignKey(C => C.Top_ID)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(C => C.Stud_Courses)
                   .WithOne(SC => SC.Course)
                   .HasForeignKey(SC => SC.Course_ID)
                   .OnDelete(DeleteBehavior.Cascade)
                   .IsRequired();

            builder.HasMany(C => C.Course_Insts)
                   .WithOne(CI => CI.Course)
                   .HasForeignKey(CI => CI.Course_ID)
                   .OnDelete(DeleteBehavior.Cascade)
                   .IsRequired();

            //builder.HasData(
            //    new Course { ID = 1 , Name = "Intro to C# Basics", Top_ID = 1, Duration = 24, Description = "How to use C#" }
            //    );
        }
    }
}
