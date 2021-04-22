using System;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int goal = 10000;
            int steps = 0;
            int totatSteps = 0;
            string input = "";
            while (goal>steps)
            {
                input = Console.ReadLine();
                if (input=="Going home")
                {
                    int stepsToHome = int.Parse(Console.ReadLine());
                    totatSteps += stepsToHome;
                    if (totatSteps>=goal)
                    {
                        Console.WriteLine("Goal reached! Good job!");
                        Console.WriteLine($"{totatSteps - goal} steps over the goal!");
                        break;
                    }
                    Console.WriteLine($"{goal-totatSteps} more steps to reach goal.");
                    break;
                }
                steps = int.Parse(input);
                totatSteps += steps;
                if (totatSteps >= goal)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{totatSteps - goal} steps over the goal!");
                    break;
                }
            }
        }
    }
}
