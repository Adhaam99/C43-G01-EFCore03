using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    class Student
    {
        [Key]
        public int ID { get; set; }

        [Length(3 , 50)]
        [Required]
        public string? FName { get; set; }
        public string? LName { get; set; }
        public string? Address { get; set; }

        [Range(22 , 40)]
        public int Age { get; set; }
        public int Dept_ID { get; set; }
        public Department Department { get; set; } = null!;
        public ICollection<Stud_Course> Stud_Courses { get; set; } = new HashSet<Stud_Course>();

    }
}
