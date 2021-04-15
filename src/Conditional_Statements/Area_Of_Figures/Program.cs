using System;

namespace Area_Of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            //inputs
            string figure = Console.ReadLine();//square, rectangle, circle or triangle
            //area of the figure
            double area;
            //conditions and outputs
            if (figure == "square")
            {
                double a = double.Parse(Console.ReadLine());
                area = a * a;
                Console.WriteLine(area);
            }
            else if (figure == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                area = a * b;
                Console.WriteLine(area);
            }
            else if (figure == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                area = Math.PI * (r * r);
                Console.WriteLine(area);
            }
            else if (figure == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double ha = double.Parse(Console.ReadLine());
                area = (a * ha) / 2;
                Console.WriteLine(area);
            }
        }
    }
}
