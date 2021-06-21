using System;

namespace PC_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double cpuPrice = double.Parse(Console.ReadLine());
            double gpuPrice = double.Parse(Console.ReadLine());
            double ramPrice = double.Parse(Console.ReadLine());
            int ramNum = int.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());
            double lev = 1.57;
            double total = 0;
            cpuPrice = cpuPrice * lev;
            gpuPrice = gpuPrice * lev;
            ramPrice = ramPrice * lev;
            ramPrice = ramPrice * ramNum;
            cpuPrice = cpuPrice - cpuPrice * discount;
            gpuPrice = gpuPrice - gpuPrice * discount;
            total = cpuPrice + gpuPrice + ramPrice;
            Console.WriteLine($"Money needed - {total:f2} leva.");
        }
    }
}
