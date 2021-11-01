using System;

namespace ConsoleApp2
{


    class Program
    {
        static void Main(string[] args)
        {
            Person human = new Person("Viktor", "Zaicev", "Nikolayevich");
            human.PrintName();
            Rektor rektor = new Rektor("KSU", "106");
            rektor.PrintRektor();
            univer university = new univer("KSU");
            university.PrintUniver();
            Facultet facultet = new Facultet("FKNFM");
            facultet.PrintFacultet();
            Dekan dekan = new Dekan("FKNFM", "414");
            dekan.PrintDekan();
            Kafedra kafedra = new Kafedra("Informatika");
            kafedra.PrintKafedra();
            ZavDekana zavdekan = new ZavDekana("Infomatika", "507");
            zavdekan.PrintZavDekana();
        }
    }
}
