using Lab7.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab7.Data
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>().Property(s => s.Id).HasDefaultValueSql("NEWID()");
        }
    }
}
