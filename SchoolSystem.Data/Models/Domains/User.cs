using System.ComponentModel.DataAnnotations;

namespace School_System.Data.Models.Domains
{
    public abstract class User
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
        public string Status { get; set; }
    }
    public enum Role
    {
        
    }
}
