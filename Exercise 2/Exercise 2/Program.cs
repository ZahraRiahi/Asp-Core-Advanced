using Exercise_2;

public class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("1:Store the name of the courses in the array ");
        Console.Write("Enter the number of course to store in array : ");
        int numCourses = int.Parse(Console.ReadLine());
        Course course = new Course(numCourses);


        Console.WriteLine("2:Store the name of the teachers in the array ");
        Console.Write("Enter the number of teachers to store in array : ");
        int numTeachers = int.Parse(Console.ReadLine());
        Teacher teacher = new Teacher(numTeachers);

        Console.WriteLine("3:Print student grades in the courses ");
        Student student = new Student("ali");
        student.getGrades();
        student.printGrades();


    }
}