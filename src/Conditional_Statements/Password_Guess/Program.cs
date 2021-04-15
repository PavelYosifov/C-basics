using System;

namespace Password_Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            //static
            string defPass = "s3cr3t!P@ssw0rd";
            //input
            string pass = Console.ReadLine();
            //condition and output
            if (defPass == pass)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
