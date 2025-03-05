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
    public class Stud_CourseModelConfiguration : IEntityTypeConfiguration<Stud_Course>
    {
        public void Configure(EntityTypeBuilder<Stud_Course> builder)
        {
            builder.HasKey(sc => new { sc.Stud_ID, sc.Course_ID });

            builder.HasOne(sc => sc.Student)
                .WithMany(s => s.Stud_Courses)
                .HasForeignKey(sc => sc.Stud_ID)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(sc => sc.Course)
                   .WithMany(C => C.Stud_Courses)
                   .HasForeignKey(sc => sc.Course_ID)
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
