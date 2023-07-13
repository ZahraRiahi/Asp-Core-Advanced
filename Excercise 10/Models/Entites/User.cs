using System.ComponentModel.DataAnnotations;
public class User{
    [Key]
    public int Id { get; set; }
    public String Phone { get; set; }

    public String Code { get; set; }

}