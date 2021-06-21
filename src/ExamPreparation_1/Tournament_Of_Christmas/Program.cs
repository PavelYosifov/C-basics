using System;

namespace Tournament_Of_Christmas
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string result = "";
            int winDays = 0;
            int looseDays = 0;
            double totalPrice = 0;
            for (int i = 0; i < n; i++)
            {
                double pricePerday = 0;
                int winGames = 0;
                int looseGames = 0;
                string sport = Console.ReadLine();
                while (sport != "Finish")
                {
                    result = Console.ReadLine();
                    if (result == "win")
                    {
                        pricePerday += 20;
                        winGames++;
                    }
                    else
                    {
                        looseGames++;
                    }
                    sport = Console.ReadLine();
                }
                if (winGames > looseGames)
                {
                    pricePerday += pricePerday * 0.1;
                    winDays++;
                }
                else
                {
                    looseDays++;
                }
                totalPrice += pricePerday;
            }
            if (winDays > looseDays)
            {
                totalPrice += totalPrice * 0.2;
                Console.WriteLine($"You won the tournament! Total raised money: {totalPrice:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {totalPrice:f2}");
            }

        }
    }
}
