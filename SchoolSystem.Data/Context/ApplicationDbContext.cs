using Microsoft.EntityFrameworkCore;
using School_System.Data.Models.Domains;

namespace School_System.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().ToTable("Students");
            modelBuilder.Entity<Teacher>().ToTable("Teachers");
            modelBuilder.Entity<Admin>().ToTable("Admins");
        }

        public DbSet<User> User { get; set; }
        public DbSet<Grade> Grade { get; set; }
        public DbSet<Subject> Subject { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Record> Record { get; set; }
    }
}
