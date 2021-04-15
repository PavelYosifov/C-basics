using System;

namespace Excellent_Result
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            double grade = double.Parse(Console.ReadLine());
            //condition
            if (grade>=5.50)
            {
                //output
                Console.WriteLine("Excellent!");
            }
        }
    }
}
