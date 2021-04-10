using System;

namespace DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            double deposit = double.Parse(Console.ReadLine()); //deposit
            int depositDue = int.Parse(Console.ReadLine()); //month of deposit
            double yearInterest = double.Parse(Console.ReadLine()); //Annual interest rate
            //Calculations
            double interestAmount = (deposit * yearInterest)/100;// calculation with %
            double interestPerMonth = interestAmount / 12;
            double totalSum = deposit + (depositDue*interestPerMonth);
            //Output
            Console.WriteLine(totalSum);
        }
    }
}
