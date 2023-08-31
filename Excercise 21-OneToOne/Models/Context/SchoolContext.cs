using Microsoft.EntityFrameworkCore;
namespace Excercise_21.Models.Entities.OneToOne;
public class SchoolContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=.;Database=RelationShipOneToOne;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity< Student >()
            .HasOne< StudentAddress >(s => s.Address)
            .WithOne(ad => ad.Student)
            .HasForeignKey< StudentAddress >(ad => ad.AddressOfStudentId);
    }
    public DbSet< Student > Students { get; set; }
    public DbSet< StudentAddress > StudentAddresses { get; set; }
}