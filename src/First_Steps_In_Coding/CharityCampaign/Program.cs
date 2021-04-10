using System;

namespace CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            //static numbers or price tags for this program
            double cake = 45;
            double waffle = 5.80;
            double pancake = 3.20;
            //Input
            int days = int.Parse(Console.ReadLine());
            int numDeserts = int.Parse(Console.ReadLine());
            int numCakes = int.Parse(Console.ReadLine());
            int numWaffles = int.Parse(Console.ReadLine());
            int numPancakes = int.Parse(Console.ReadLine());
            //Calculations
            double cakeAmount = numCakes * cake;
            double waffleAmount = numWaffles * waffle;
            double pancakesAmount = numPancakes * pancake;
            double totalAmountPerDay = (cakeAmount + waffleAmount + pancakesAmount) * numDeserts;
            double totalAmountForCampain = totalAmountPerDay * days;
            double totalAmount = totalAmountForCampain - (totalAmountForCampain / 8);//deviding by 8 because it is said in the condition
            //Output
            Console.WriteLine(totalAmount);
        }
    }
}
