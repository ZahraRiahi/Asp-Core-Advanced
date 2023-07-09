using Exercise_2;
using System;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("************************************************** ");
        Console.WriteLine("************************************************** ");

        Console.WriteLine("1:Store the name of the courses in the array ");
        Console.Write("Enter the number of course to store in array : ");
        int numCourses = int.Parse(Console.ReadLine());
        Course course = new Course(numCourses);
        Console.WriteLine("************************************************** ");
        Console.WriteLine("************************************************** ");



        Console.WriteLine("2:Store the name of the teachers in the array ");
        Console.Write("Enter the number of teachers to store in array : ");
        int numTeachers = int.Parse(Console.ReadLine());
        Teacher teacher = new Teacher(numTeachers);
        Console.WriteLine("************************************************** ");
        Console.WriteLine("************************************************** ");


        Console.WriteLine("3:Print student grades in the courses ");
        Student student = new Student("ali");
        student.printGrades();
        Console.WriteLine("************************************************** ");
        Console.WriteLine("************************************************** ");

        Console.WriteLine("4:Print the name of the course and teacher of the failed students ");
        Console.Write("Enter the name of student : ");
       String studentName = Console.ReadLine();
        Console.Write("Enter the name of course : ");
        String courseName = Console.ReadLine();
        Console.Write("Enter the name of teacher : ");
        String teacherName = Console.ReadLine();
        bool isFailed;
        Console.Write("Enter the name of student : ");
        Console.Write("Did the student fail the course?(true/false): ");
        isFailed = Convert.ToBoolean(Console.ReadLine());
        if (isFailed)
        {
            Console.WriteLine("Student {0}  has failed the course {1} with teacher {2}.", studentName, courseName, teacherName);


        }
        else
        {
            Console.WriteLine("Student {0}  has passed the course {1} with teacher {2}.", studentName, courseName, teacherName);

        }
        Console.WriteLine("************************************************** ");
        Console.WriteLine("************************************************** ");













    }
}