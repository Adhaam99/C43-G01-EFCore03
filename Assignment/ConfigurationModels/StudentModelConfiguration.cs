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
    class StudentModelConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasOne(S => S.Department)
                .WithMany(D => D.Students)
                .HasForeignKey(S => S.Dept_ID)
                .IsRequired();

            builder.HasMany(S => S.Stud_Courses)
                .WithOne(SC => SC.Student)
                .HasForeignKey(SC => SC.Stud_ID)
                .IsRequired();
        }
    }
}
