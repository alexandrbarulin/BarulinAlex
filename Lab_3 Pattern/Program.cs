using System;

namespace SingletonPattern
{
    public class Singleton
    {
        public string Date { get; private set; }
        public static string text = "hello";
        private Singleton()
        {
            Console.WriteLine($"Singleton ctor {DateTime.Now}");
            Date = DateTime.Now.ToString();
        }

        public static Singleton GetInstance()
        {
            Console.WriteLine($"GetInstance {DateTime.Now}");
            return Nested.instance;
        }

        private class Nested
        {
            internal static readonly Singleton instance = new Singleton();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Main {DateTime.Now}");
            Console.WriteLine(Singleton.text);
            Console.Read();
        }
    }
}
