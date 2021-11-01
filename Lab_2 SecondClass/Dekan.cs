using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Dekan : Person
    {
        protected string facultet;
        protected string auditory;
        public Dekan(string newFacultet, string newAuditory) : base("Kyshnir", "Natalya", "Petrovna")
        {
            this.facultet = newFacultet;
            this.auditory = newAuditory;
        }


        public void PrintDekan()
        {
            Console.WriteLine($"Dekan : {FirstName} {SecondName} {Fathers}, the dekan of {facultet}. Auditory is {auditory}");
        }

    }
}
