using System;

namespace SequenceTwoKPlusOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = 1;
            while (p<=n)
            {
                Console.WriteLine(p);
                p = p * 2 + 1;   
            }
        }
    }
}
