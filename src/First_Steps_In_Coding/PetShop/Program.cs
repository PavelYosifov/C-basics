using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //static nums
            double dogfood = 2.50;
            double otherfood = 4;
            //input
            int numDog = int.Parse(Console.ReadLine()); //0-100
            int numAnimal = int.Parse(Console.ReadLine()); //0-100
            //calculations
            double cost =(dogfood*numDog)+(numAnimal*otherfood);
            //output
            Console.WriteLine($"{cost} lv.");
        }
    }
}
