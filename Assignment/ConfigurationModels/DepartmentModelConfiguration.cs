using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Assignment.ConfigurationModels
{
    public class DepartmentModelConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.Property(D=> D.ID).UseIdentityColumn(10 , 10);

            builder.HasOne(D => D.Manager)
                   .WithOne(I => I.ManagedDepartment)
                   .HasForeignKey<Department>(D => D.Ins_ID)
                   .OnDelete(DeleteBehavior.NoAction);

            //builder.HasData(

            //    new Department() { ID = 10, Name = "Computer Science", HiringDate = DateOnly.FromDateTime(DateTime.Now) }
            //    );
        }
    }
}
