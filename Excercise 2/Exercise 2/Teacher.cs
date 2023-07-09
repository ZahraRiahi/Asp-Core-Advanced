using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    internal class Teacher
    {
        string[] teachersName;


        public Teacher(int numOfTeachers)
        {
            teachersName = new string[numOfTeachers];

            for (int i = 0; i < numOfTeachers; i++)
            {
                Console.Write("Enter the name of teacher {0}: ", i + 1);
                teachersName[i] = Console.ReadLine();
            }
            for (int i = 0; i < numOfTeachers; i++)
            {
                Console.Write("print the name of teacher {0}: ", i + 1);
                Console.WriteLine(teachersName[i]);
            }
        }
    }
}

