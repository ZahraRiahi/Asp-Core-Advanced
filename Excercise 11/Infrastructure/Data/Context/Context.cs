using Microsoft.EntityFrameworkCore;

public class Context:DbContext{
    public DbSet<Tbl_User> Tbl_Users{get;set;}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseSqlServer(@"Server=.;Database=cleandb;Trusted_Connection=SSPI;Encrypt=false;TrustserverCertificate=true");
    }
}