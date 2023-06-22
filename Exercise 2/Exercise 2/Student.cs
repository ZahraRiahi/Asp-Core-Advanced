using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    internal class Student
    {

        public string name;
        public Course course=new Course(3);
        public Teacher teacherName;
        public int grade { get; set; }
        public Student(string name)
        {
            this.name = name;
        }

        public void getGrades()
    {
        Console.WriteLine($"{name} Dear student,Enter the grades of courses :");
        Console.WriteLine($"Math: {grade}");
        Console.WriteLine($"Chemistry: {grade}");
        Console.WriteLine($"Arabic: {grade}");
    }
        public void printGrades()
        {
            Console.WriteLine($"{name} Dear student, the grades are as follows:");
            Console.WriteLine($"Math: {grade}");
            Console.WriteLine($"Chemistry: {grade}");
            Console.WriteLine($"Arabic: {grade}");
        }

    }
}
