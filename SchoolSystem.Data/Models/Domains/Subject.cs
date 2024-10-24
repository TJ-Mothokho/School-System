using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_System.Data.Models.Domains
{
    public class Subject
    {
        public int SubjectID { get; set; }
        public string Name { get; set; }

        [ForeignKey("Teacher")]
        public int? TeacherID { get; set; }
        [ForeignKey("Grade")]
        public string GradeID { get; set; }


        public ICollection<Record> Records { get; set; }

        // Navigation properties
        public Teacher Teacher { get; set; }
    }
}
