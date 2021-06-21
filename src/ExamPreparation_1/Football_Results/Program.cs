using System;

namespace Football_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            int winCount = 0;
            int drawCount = 0;
            int loseCount = 0;
            for (int i = 0; i < 3; i++)
            {
               string game = Console.ReadLine();
                if (game[0] > game[2])
                {
                    winCount++;
                }
                else if (game[0] < game[2])
                {
                    loseCount++;
                }
                else
                {
                    drawCount++;
                }
            }
            Console.WriteLine($"Team won {winCount} games.");
            Console.WriteLine($"Team lost {loseCount} games.");
            Console.WriteLine($"Drawn games: {drawCount}");

        }
    }
}
