using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace WebApplication1.Models
{
    public class Context : DbContext
    {
        
        public Context(DbContextOptions<Context> optionsBuilder) : base(optionsBuilder) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TraineeCourse>().HasKey(tc => new { tc.TraineeID, tc.CourseID });
            base.OnModelCreating(modelBuilder);
        }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Track> Tracks { get; set; }
        public virtual DbSet<Trainee> Trainees { get; set; }
        public virtual DbSet<TraineeCourse> TraineeCoursess { get; set; }
    }
}
