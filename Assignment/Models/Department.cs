﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    public class Department
    {
        
        public int ID { get; set; }

        [Column("Name", TypeName = "varchar(50)")]
        [Length(3, 50)]
        public string? Name { get; set; }
        public int? Ins_ID { get; set; }
        public DateOnly HiringDate { get; set; }
        public virtual Instructor Manager { get; set; } = null!;
        public virtual ICollection<Instructor> Instructors { get; set; } = new HashSet<Instructor>();
        public virtual ICollection<Student> Students { get; set; } = new HashSet<Student>();

        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Manager: {Manager}, Hiring Date: {HiringDate}";
        }
    }
}
