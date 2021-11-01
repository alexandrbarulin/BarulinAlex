using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class ZavDekana : Person
    {
        protected string kafedra;
        protected string auditory;
        public ZavDekana(string newKafedra, string newAuditory) : base("Pypkin", "Grisha", "Bogdanovich")
        {
            this.kafedra = newKafedra;
            this.auditory = newAuditory;
        }


        public void PrintZavDekana()
        {
            Console.WriteLine($"ZavDekana : {FirstName} {SecondName} {Fathers}, the zavdekan of {kafedra}. Auditory is {auditory}");
        }
    }
}
