namespace Excercise_21.Models.Entities.ManyToMany;
public class Student
{
    public int StudentId { get; set; }
    public string Name { get; set; }
    public IList< StudentCourse > StudentCourses { get; set; }
}