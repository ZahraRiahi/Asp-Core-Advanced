using Excercise_21.Models.Entities.ManyToMany;
using Microsoft.EntityFrameworkCore;
public class SchoolContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=.;Database=RelationShipManyToMany;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity< StudentCourse >().HasKey(sc => new { sc.StudentId, sc.CourseId });
    }
     
    public DbSet< Student > Students { get; set; }
    public DbSet< Course > Courses { get; set; }
    public DbSet< StudentCourse > StudentCourses { get; set; }
}