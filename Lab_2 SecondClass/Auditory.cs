using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Auditory
    {
        protected string auditory;
        public Auditory(string newAuditory) 
        {
            this.auditory = newAuditory;
        }
        public string Auditories
        {
            get { return this.auditory; }
            set { this.auditory = value; }
        }
        public void PrintUniver()
        {
            Console.WriteLine($"Auditory : {auditory}");
        }
    }
}
