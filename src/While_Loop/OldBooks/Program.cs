using System;

namespace OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string searchedBook = Console.ReadLine();
            int count = 0;
            bool isBookFound = false;
            string book = Console.ReadLine();
            while (book !="No More Books")
            {
                if (book==searchedBook)
                {
                    isBookFound = true;
                    break;
                }
                count++;
                book = Console.ReadLine();
            }
            if (isBookFound)
            {
                Console.WriteLine($"You checked {count} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {count} books.");
                Environment.Exit(0);
            }
           
        }
    }
}
