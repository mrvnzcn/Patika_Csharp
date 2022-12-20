using System;

namespace console_programlama
{
    class Program 
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("Adin:");
            string name = Console.ReadLine();
            Console.WriteLine("Soyadin:");
            string surname = Console.ReadLine();

            Console.WriteLine("Neler Oluyor?" + name + " " + surname);
        }
    }
}