using System;

namespace BirthdayParty
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            double hall = double.Parse(Console.ReadLine());
            //Calculations
            double cake = (hall * 20) / 100;//Or salary*0.2;
            double drinks = cake - (0.45 * cake);
            double animator = hall / 3;
            double totalCosts = hall + cake + drinks + animator;
            //Output
            Console.WriteLine(totalCosts);
        }
    }
}
