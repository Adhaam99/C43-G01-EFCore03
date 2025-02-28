using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    class Topic
    {
        public int ID { get; set; }

        [Required]
        [Length(3, 50)]
        public string? Name { get; set; }
        public ICollection<Course> Courses { get; set; } = new HashSet<Course>();
    }
}
