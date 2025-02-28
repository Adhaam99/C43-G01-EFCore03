using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment.DbContext
{
    internal class ITIDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public ITIDbContext() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = AssignmentITI; Trusted_Connection = true; TrustServerCertificate = True");
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Course_Inst> Course_Insts { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Stud_Course> stud_Courses { get; set; }

    }
}
