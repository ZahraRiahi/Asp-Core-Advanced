namespace Excercise_21.Models.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
   [Table("EmployeeDetail")]  
    public partial class EmployeeDetail  
    {  
        [Key, ForeignKey("Employee")]  
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]  
        public int EmployeeId  
        {  
            get;  
            set;  
        }  
        [StringLength(10)]  
        public string Gender  
        {  
            get;  
            set;  
        }  
        [StringLength(255)]  
        public string EmailAddress  
        {  
            get;  
            set;  
        }  
        [StringLength(50)]  
        public string PhoneNumber  
        {  
            get;  
            set;  
        }  
        public Employee Employee
        {  
            get;  
            set;  
        }  
    }  