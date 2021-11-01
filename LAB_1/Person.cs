using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Person
    {
         
 
    public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Fathers { get; set; }
        public string age { get; set; }

        public void PrintName()
        {
            Console.WriteLine($"ПІБ:{FirstName} " + $"{SecondName} " + $"{Fathers}");
            Console.WriteLine($"Дата Рождения: {age}");


        }
    }
}
