using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Student : Person
    {
        public string facultet { get; set; }
        public string course { get; set; }
        public void PrintStudent()
        {
            Console.WriteLine($"Факультет: {facultet}");
            course.Split();
            int i = Convert.ToInt32(course[3]);
            if (course.Contains("м"))
                Console.WriteLine($"Курс: {i - 44}");
            else
                Console.WriteLine($"Курс: {i - 48}");
        }
    }
}
