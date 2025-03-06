using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Models
{
    public class Stud_Course
    {
        public int Stud_ID { get; set; }
        public virtual Student Student { get; set; } = null!;
        public int Course_ID { get; set; }
        public virtual Course Course { get; set; } = null!;
        [Range(0, 100)]
        public int Grade { get; set; }

        public override string ToString()
        {
            return $"Student ID: {Stud_ID}, Course ID: {Course_ID}, Grade: {Grade}";
        }
    }
}
