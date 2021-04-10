using System;

namespace Projects_Creation
{
    class Program
    {
        static void Main(string[] args)
        {
            //static nums
            int project = 3;
            //input
            string name = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());//0-100
            //calculations
            int hours = num * project;
            //output
            Console.WriteLine($"The architect {name} will need {hours} hours to complete {num} project/s.");
            /*There is another simpler way to make this
             *program. We know by default it takes 3 hours
             *to complete 1 project. So we can remove
             *int project = 3 and directly to write
             *int hours = num * 3;
             */
        }
    }
}
