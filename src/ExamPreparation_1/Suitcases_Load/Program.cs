using System;

namespace Suitcases_Load
{
    class Program
    {
        static void Main(string[] args)
        {
            double luggageSpace = double.Parse(Console.ReadLine());
            string keyword = Console.ReadLine();
            double briefcase = 0;
            int briefcaseCount = 0;
            while (keyword != "End")
            {
                briefcase = double.Parse(keyword);
               
                briefcaseCount++;
                if (briefcaseCount % 3 == 0)
                {
                    briefcase += briefcase * 0.1;
                }
                if (luggageSpace < briefcase)
                {
                    Console.WriteLine("No more space!");
                    briefcaseCount--;
                    break;
                }
                luggageSpace -= briefcase;
                keyword = Console.ReadLine();
            }
            if (keyword == "End")
            {
                Console.WriteLine("Congratulations! All suitcases are loaded!");
            }
            Console.WriteLine($"Statistic: {briefcaseCount} suitcases loaded.");
        }
    }
}
