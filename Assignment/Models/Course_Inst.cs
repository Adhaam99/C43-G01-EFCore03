using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Models
{
    [PrimaryKey("Inst_ID", "Course_ID")]
    public class Course_Inst
    {
        public int Inst_ID { get; set; }
        public virtual Instructor Instructor { get; set; } = null!;
        public int Course_ID { get; set; }
        public virtual Course Course { get; set; } = null!;
        public int Evaluation { get; set; }

        public override string ToString()
        {
            return $"Instructor ID: {Inst_ID}, Course ID: {Course_ID}, Evaluation: {Evaluation}";
        }
    }
}
