using System.ComponentModel.DataAnnotations;
namespace Infrstructure.Data.Dto;
    public class DtoProduct{
    

    public int Id{get;set;}
    public string ProductName{get;set;}
    public string Brand{get;set;}
    public int Price{get;set;}
    public  string Category{get;set;}
    public string ItemWeigth{get;set;}
   public string Description{get;set;}

}