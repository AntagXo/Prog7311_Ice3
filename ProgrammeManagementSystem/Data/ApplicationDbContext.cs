using Microsoft.EntityFrameworkCore;
using ProgrammeManagementSystem.Models;
using System.Security.Claims;

namespace ProgrammeManagementSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Lecturer> Lecturers { get; set; }   //come back to change to align with controllers and views 
        public DbSet<Module> Modules { get; set; }
        public DbSet<Registration> Registrations { get; set; }
        public DbSet<Student> Students { get; set; }

        public DbSet<ModuleAssignment> ModuleAssignments { get; set; }

    }
}
