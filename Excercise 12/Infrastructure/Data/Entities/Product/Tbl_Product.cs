using System.ComponentModel.DataAnnotations;
namespace Infrstructure.Data.Entities.Product;
    public class Tbl_Product{
    

       [Key]
    public int Id{get;set;}
    public string ProductName{get;set;}
    public string Brand{get;set;}
    public int Price{get;set;}
    public  string Category{get;set;}
    public string ItemWeigth{get;set;}
   public string Description{get;set;}

}