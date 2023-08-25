using System.ComponentModel.DataAnnotations;

namespace Excercise_20.Models.Entities;
public class Tbl_Menu
{
    [Key]
    public int Id { get; set;}
    public string CategoryName { get; set;}
    public int ParentId { get; set;}
     public bool Status { get; set;}

}