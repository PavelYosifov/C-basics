using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int hight = int.Parse(Console.ReadLine());
            int space = width * lenght * hight;
            string keyWord = Console.ReadLine();
            int numBoxes = 0;
            int totalBoxes = 0;
            int spaceLeft = 0;
            while (keyWord != "Done")
            {
                numBoxes = int.Parse(keyWord);
                space -= numBoxes;
                if (space <0)
                {
                    Console.WriteLine($"No more free space! You need {space *-1} Cubic meters more.");
                    Environment.Exit(0);
                }
                keyWord = Console.ReadLine();
            }
            spaceLeft = space - totalBoxes;
            Console.WriteLine($"{spaceLeft} Cubic meters left.");
        }
    }
}
