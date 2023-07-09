using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    internal class Course
    {
        string[] coursesName;

        public Course()
        {
        }

        public Course(int numOfCourses)
        {
            coursesName = new string[numOfCourses];

            for (int i = 0; i < numOfCourses; i++)
            {
                Console.Write("Enter the name of course {0}: ", i + 1);
                coursesName[i] = Console.ReadLine();
            }
            for (int i = 0; i < numOfCourses; i++)
            {
                Console.Write("print the name of course {0}: ", i + 1);
                  Console.WriteLine(coursesName[i]);
            }
        }
    }
}

