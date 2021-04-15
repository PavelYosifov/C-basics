using System;

namespace Number_From_100_To_200
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int num = int.Parse(Console.ReadLine());
            //conditions with outputs
            if (num < 100)
            {
                Console.WriteLine("Less than 100");
            }
            else if (num <= 200)
            {
                Console.WriteLine("Between 100 and 200");
            }
            else
            {
                Console.WriteLine("Greater than 200");
            }
        }
    }
}
