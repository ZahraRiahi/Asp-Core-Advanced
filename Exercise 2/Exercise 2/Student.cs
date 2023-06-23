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
        public Course course=new Course();

        public Teacher teacherName;
        public int grade { get; set; }
        public Student(string name)
        {
            this.name = name;
        }

        public void printGrades()
    {
            Console.Write("please enter name of student:");
            name = Console.ReadLine();
            Console.Write("please enter grade of Math:");
            int mathGrade = int.Parse(Console.ReadLine());
            Console.Write("please enter grade of chemistry:");
            int chemistryGrade = int.Parse(Console.ReadLine());
            Console.Write("please enter grade of arabic:");
            int arabicGrade = int.Parse(Console.ReadLine());
            Console.WriteLine("the student's grades in the courses are as follows:");
            Console.WriteLine($"Math: {mathGrade}");
            Console.WriteLine($"Chemistry: {chemistryGrade}");
            Console.WriteLine($"Arabic: {arabicGrade}");
    }

    }
}
