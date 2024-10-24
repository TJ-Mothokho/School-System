using Microsoft.EntityFrameworkCore;
//using School_System.Data.Models.Domains;

namespace School_System.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }




    }
}
