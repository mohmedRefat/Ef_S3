
using Microsoft.EntityFrameworkCore;

namespace OnlineLearningPlatform.Data;

public class AppDbContext : DbContext
{
    public DbSet<Instructor> Instructors { get; set; }

    public DbSet<Category> Categories { get; set; }

    public DbSet<Course> Courses { get; set; }

    public DbSet<Student> Students { get; set; }

    public DbSet<Enrollment> Enrollments { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            string connectionString =
                Environment.GetEnvironmentVariable("DB_CONNECTION")
                ?? throw new Exception("Database connection string is missing.");

            optionsBuilder.UseSqlServer(connectionString);
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(
            typeof(AppDbContext).Assembly
        );

        base.OnModelCreating(modelBuilder);
    }
}
