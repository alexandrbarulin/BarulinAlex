using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Teacher : Person
    {
        public string kafedra { get; set; }
        public string dolzhnost { get; set; }
        public void PrintTeacher()
        {
            Console.WriteLine($"Кафедра: {kafedra}");
            Console.WriteLine($"Должность: {dolzhnost}");
        }
    }

}
