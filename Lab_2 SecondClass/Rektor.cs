using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Rektor : Person
    {
        protected string univer;
        protected string auditory;
        public Rektor(string newUniver, string newAuditory) : base("Spivakovskiy", "Alex", "Alexievich")
        {
            this.univer = newUniver;
            this.auditory = newAuditory;
        }
        

        public void PrintRektor() 
        {
            Console.WriteLine($"Rektor : {FirstName} {SecondName} {Fathers}, the rektor of university {univer}. Auditory is {auditory}");
        }

           

}
}
