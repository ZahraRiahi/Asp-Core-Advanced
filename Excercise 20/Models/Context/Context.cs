using Microsoft.EntityFrameworkCore;
using Excercise_20.Models.Entities;


namespace Excercise_20.Models.Context;
public class Context : DbContext
{
        public DbSet<Tbl_Menu> Tbl_Menus { get; set; }
    public object Tbl_Menu { get; internal set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder){
            optionBuilder.UseSqlServer(@"Server=.;Database=Menu;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true");
        }
}

