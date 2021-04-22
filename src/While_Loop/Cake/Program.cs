using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int cakeWidth = int.Parse(Console.ReadLine());
            int cakeLenght = int.Parse(Console.ReadLine());
            int cake = cakeLenght * cakeWidth;
            int piece = 0;
            int totalPieces = 0;
            while (cake > totalPieces)
            {
                string input = Console.ReadLine();
                if (input == "STOP")
                {
                    Console.WriteLine($"{cake - totalPieces} pieces are left.");
                    break;
                }
                piece = int.Parse(input);
                totalPieces += piece;
                if (totalPieces > cake)
                {
                    Console.WriteLine($"No more cake left! You need {totalPieces - cake} pieces more.");
                }
            }

        }
    }
}
