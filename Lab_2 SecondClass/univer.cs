using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class univer
    {
        protected string university;

        public univer(string newUniversity)
        {
            this.university = newUniversity;
        }
        public string Univers 
            {
            get { return this.university; }
            set { this.university = value; }
}
        public void PrintUniver() 
        {
            Console.WriteLine($"University : {university}");
        }
    }
}
