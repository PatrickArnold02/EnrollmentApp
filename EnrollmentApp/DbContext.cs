using Microsoft.EntityFrameworkCore;
using EnrollmentApp.Models;  // Adjust this using directive to point to where your models are defined

namespace EnrollmentApp
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // DbSets for your entities go here
        // public DbSet<Student> Students { get; set; }
        // Add additional DbSets for other entity models
    }
}
