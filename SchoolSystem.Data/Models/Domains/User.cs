﻿using System.ComponentModel.DataAnnotations;

namespace School_System.Data.Models.Domains
{
    public abstract class User
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email 
        {
            get
            {
                return $"{FirstName.ToLower()}{LastName.ToLower()}{Id}@academy.ac.za";
            }
        }
        public string Password { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string Gender { get; set; }
        public Role Role { get; set; }
        public string Status { get; set; }
    }
    public enum Role
    {
        Student,
        Teacher,
        Admin
    }
    public enum  Gender
    {
        Male,
        Female
    }
}
