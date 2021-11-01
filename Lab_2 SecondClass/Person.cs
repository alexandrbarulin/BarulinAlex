using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Person
    {


        protected string FirstName;
        protected string SecondName;
        protected string Fathers;

        public Person(string newFirstName, string newSecondName, string newFathers)
        {
            this.FirstName = newFirstName;
            this.SecondName = newSecondName;
            this.Fathers = newFathers;
        }

        public void PrintName()
        {
            Console.WriteLine($"ПІБ:{FirstName} " + $"{SecondName} " + $"{Fathers}");
        }
    }
}