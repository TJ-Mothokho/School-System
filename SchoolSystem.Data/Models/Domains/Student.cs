using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_System.Data.Models.Domains
{
    public class Student : User
    {
        [ForeignKey("Class")]
        public int ClassID { get; set; }
        public ICollection<Record> Records { get; set; }
    }
}
