using System.ComponentModel.DataAnnotations;

public class Tbl_User{

[Key]
     public int id{get;set;}

    public string userName{get;set;}
    public string password{get;set;}

}