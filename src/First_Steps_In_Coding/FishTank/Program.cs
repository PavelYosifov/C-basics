using System;

namespace FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 liter water is equal to 1 cubic dm
            //Input
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());
            //Calculations
            int aquariumVolume = lenght * width * height;
            double totalLitersFit = aquariumVolume * 0.001;
            double percentsFromAquarium = percentage*0.01;
            double totalLitersNeeded = totalLitersFit * (1 - percentsFromAquarium);
            //Output
            Console.WriteLine(totalLitersNeeded);
        }
    }
}
