using System;

namespace ConsoleApp1 { 
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student { FirstName = "Барулин", SecondName = "Алксандр", Fathers = "Алксандрович", age = "18.07.2003", course = "12-241", facultet = "ФКНФМ" };
            student.PrintName();
            student.PrintStudent();
            Student student1 = new Student { FirstName = "Глущук", SecondName = "Андрей", Fathers = "Сергеевич", age = "29.05.2001", course = "12-141м", facultet = "ФКНФМ" };
            student1.PrintName();
            student1.PrintStudent();
            Teacher teacher = new Teacher { FirstName = "Зайцев", SecondName = "Юрий", Fathers = "Николаевич", age = "12.5.1986", dolzhnost = "Доцент", kafedra = "Оброзотворче мистецтво" };
            teacher.PrintName();
            teacher.PrintTeacher();
        }
    }
}
