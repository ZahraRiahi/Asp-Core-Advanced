namespace Excercise_21.Models.Entities.ManyToMany;

public class Course
{
    public int CourseId { get; set; }
    public string CourseName { get; set; }
    public string Description { get; set; }
    public IList< StudentCourse > StudentCourses { get; set; }
}