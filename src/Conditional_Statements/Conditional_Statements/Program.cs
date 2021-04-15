using System;

namespace Conditional_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            bool isPositive = a > 0;
            Console.WriteLine(a < b);//true
            Console.WriteLine(isPositive);//true
            Console.WriteLine(a > 100);//false
            Console.WriteLine(a < a);//false
            Console.WriteLine(a <= 5);//true
            Console.WriteLine(a != 5);//false
            Console.WriteLine(b == 2 * a);//true
            string firstName = "Stoyan";
            string lastName = "Shopov";
            bool result = firstName == lastName;
            Console.WriteLine(result);
        }
    }
}
