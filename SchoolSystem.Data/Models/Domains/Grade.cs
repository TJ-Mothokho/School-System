using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_System.Data.Models.Domains
{
    public class Grade
    {
        [Key]
        public string GradeID { get; set; }
        public ICollection<Subject> Subjects { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
