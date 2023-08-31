using Microsoft.EntityFrameworkCore;
namespace Excercise_21.Models.Entities;


public class OneToOneContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=.;Database=RelationShip;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true");
    } 
        public virtual DbSet < Employee > Employees  
        {  
            get;  
            set;  
        }  
        public virtual DbSet < EmployeeDetail > EmployeeDetails  
        {  
            get;  
            set;  
        }  
       
    }
    