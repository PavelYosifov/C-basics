using System;

namespace PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    for (int k = 97; k < 97 + l; k++)//ASCII Table
                    {
                        for (int m = 97; m < 97 + l; m++)//ASCII Table
                        {
                            for (int o = 1; o <= n; o++)
                            {
                                if (o > i && o > j)
                                {
                                    Console.Write("{0}{1}{2}{3}{4} ", i, j, Convert.ToChar(k), Convert.ToChar(m), o);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
