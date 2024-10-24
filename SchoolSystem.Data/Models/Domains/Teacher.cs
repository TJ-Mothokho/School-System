using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_System.Data.Models.Domains
{
    public class Teacher : Staff
    {
        [ForeignKey("Subject")]
        public int SubjectID { get; set; }

        [ForeignKey("Class")]
        public int ClassID { get; set; }
    }
}
