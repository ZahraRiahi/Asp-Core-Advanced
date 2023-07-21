using Infrstructure.Data.Entities.Product;
using Microsoft.EntityFrameworkCore;

public class Context:DbContext{
    public DbSet<Tbl_Product> Tbl_Products{get;set;}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseSqlServer(@"Server=.;Database=ProductDb;Trusted_Connection=SSPI;Encrypt=false;TrustserverCertificate=true");
    }
}