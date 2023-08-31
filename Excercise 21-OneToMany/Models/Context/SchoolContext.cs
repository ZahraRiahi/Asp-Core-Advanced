using Microsoft.EntityFrameworkCore;
namespace Excercise_21.Models.Entities.OneToMany;
public class SchoolContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=.;Database=RelationShipOneToMany;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity< Student >()
            .HasOne< Grade >(s => s.Grade)
            .WithMany(g => g.Students)
            .HasForeignKey(s => s.CurrentGradeId)
            .OnDelete(DeleteBehavior.Cascade);
    }
    public DbSet< Grade > Grades { get; set; }
    public DbSet< Student > Students { get; set; }
}