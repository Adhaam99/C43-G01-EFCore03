using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    public class Instructor
    {
        
        public int ID { get; set; }
        public string Name { get; set; } = null!;
        public int Bouns { get; set; }

        [Column("Salary" , TypeName = "decimal(10,2)")]
        public decimal Salary { get; set; }
        public string? Address { get; set; }
        [Column("HourRate", TypeName = "decimal(10,2)")]
        public decimal HourRate { get; set; }
        public int Dep_ID { get; set; }
        public virtual Department? ManagedDepartment { get; set; }
        public virtual Department Department { get; set; } = null!;
        public virtual ICollection<Course_Inst> Course_Insts { get; set; } = new HashSet<Course_Inst>();

        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Address: {Address}, Bouns: {Bouns}, Salary: {Salary}, HourRate: {HourRate}, Department: {Department}";
        }
    }
}
