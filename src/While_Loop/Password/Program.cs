using System;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string user = Console.ReadLine();
            string password = Console.ReadLine();
            string input = Console.ReadLine();
            while (input != password)
            {
                input = Console.ReadLine();
            }
            Console.WriteLine($"Welcome {user}!");
        }
    }
}
