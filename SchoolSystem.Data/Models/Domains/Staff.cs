using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_System.Data.Models.Domains
{
    public class Staff : User
    {
        public DateOnly DateStarted { get; set; }
        public DateOnly DateEnded { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public TypeOfStuff Type { get; set; }
    }
    public enum TypeOfStuff
    {
        Teacher,
        Admin
    }
}
