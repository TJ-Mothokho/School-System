﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace School_System.Data.Models.Domains
{
    public class Teacher : Staff
    {
        public int ClassNumber { get; set; }
        public ICollection<Subject> Subjects { get; set; }
    }
}
