using EFrelationsANDmigrations.Models;
using Microsoft.EntityFrameworkCore;

namespace EFrelationsANDmigrations.Data
{
    public class UniversityContext : DbContext
    {
        public UniversityContext(DbContextOptions<UniversityContext> options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<StudentsStudies>().HasKey(sc => new { sc.StudentId, sc.StudyId });
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Study> Studies { get; set; }
        public DbSet<StudentsStudies> StudentsStudies { get; set; }
        public DbSet<Sensei> Senseis { get; set; }
    }
}
