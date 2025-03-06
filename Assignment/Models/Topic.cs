using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    public class Topic
    {
        public int ID { get; set; }

        [Length(3, 50)]
        public string? Name { get; set; }
        public virtual ICollection<Course> Courses { get; set; } = new HashSet<Course>();

        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}";
        }
    }
}
