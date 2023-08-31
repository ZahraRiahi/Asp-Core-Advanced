namespace Excercise_21.Models.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Employee")]  
    public partial class Employee  
    {  
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]  
        public int EmployeeId  
        {  
            get;  
            set;  
        }  
        [Required]  
        [StringLength(50)]  
        public string FirstName  
        {  
            get;  
            set;  
        }  
        [Required]  
        [StringLength(50)]  
        public string LastName  
        {  
            get;  
            set;  
        }  
        [StringLength(50)]  
        public string MiddleName  
        {  
            get;  
            set;  
        }  
        public EmployeeDetail EmployeeDetail 
        {  
            get;  
            set;  
        }  
    } 