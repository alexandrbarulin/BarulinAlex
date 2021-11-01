using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Kafedra
    {
        protected string kafedra;

        public Kafedra(string newKafedra)
        {
            this.kafedra = newKafedra;
        }
        public string kafedras
        {
            get { return this.kafedra; }
            set { this.kafedra = value; }
        }
        public void PrintKafedra()
        {
            Console.WriteLine($"Kafedra : {kafedra}");
        }
    }
}
