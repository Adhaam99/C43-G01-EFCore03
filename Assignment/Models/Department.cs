using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    class Department
    {
        [Key]
        public int ID { get; set; }

        [Column("Name", TypeName = "varchar(50)")]
        [Length(3, 50)]
        public string? Name { get; set; }
        [ForeignKey(nameof(Manager))]
        public int Ins_ID { get; set; }
        public DateOnly HiringDate { get; set; }

        [Required]
        [InverseProperty(nameof(Instructor.Department))]
        public Instructor Manager { get; set; } = null!;
        public ICollection<Instructor> Instructors { get; set; } = new HashSet<Instructor>();
        public ICollection<Student> Students { get; set; } = new HashSet<Student>();

    }
}
