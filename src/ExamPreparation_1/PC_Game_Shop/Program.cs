using System;

namespace PC_Game_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int hearthstone = 0;
            int overwatch = 0;
            int fornite = 0;
            int others = 0;
            string game = "";
            for (int i = 0; i < n; i++)
            {
                game = Console.ReadLine();
                switch (game)
                {
                    case "Hearthstone":
                        hearthstone++;
                        break;
                    case "Fornite":
                        fornite++;
                        break;
                    case "Overwatch":
                        overwatch++;
                        break;
                    default:
                        others++;
                        break;
                }
            }
            double hearthstonePercent = hearthstone * 1.0 / n * 100;
            double fornitePercent = fornite * 1.0 / n * 100;
            double overwatchPercent = overwatch * 1.0 / n * 100;
            double othersePercent = others * 1.0 / n * 100;
            Console.WriteLine($"Hearthstone - {hearthstonePercent:f2}%");
            Console.WriteLine($"Fornite - {fornitePercent:f2}%");
            Console.WriteLine($"Overwatch - {overwatchPercent:f2}%");
            Console.WriteLine($"Others - {othersePercent:f2}%");
        }
    }
}
