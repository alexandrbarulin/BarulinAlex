using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Facultet
    {
        
            protected string facultet;

            public Facultet(string newFacultet)
            {
                this.facultet = newFacultet;
            }
            public string facultets
            {
                get { return this.facultet; }
                set { this.facultet = value; }
            }
            public void PrintFacultet()
            {
                Console.WriteLine($"Facultet : {facultet}");
            }
        
    }
}
