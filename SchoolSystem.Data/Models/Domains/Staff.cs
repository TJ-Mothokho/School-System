using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_System.Data.Models.Domains
{
    public abstract class Staff : User
    {
        public DateOnly DateStarted { get; set; }
        public DateOnly DateEnded { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; } = 0.00m;
        public TypeOfStuff Type { get; set; }
    }
    public enum TypeOfStuff
    {
        Teacher,
        Admin
    }
}
