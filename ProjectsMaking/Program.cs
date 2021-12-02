using System;

namespace ProjectsMaking
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            string name = Console.ReadLine();
            int projectsCount = int.Parse(Console.ReadLine());

            // 3 hours per project
            int hours = projectsCount * 3;

            //output
            Console.WriteLine($"The architect {name} will need {hours} hours to complete {projectsCount} project/s.");
        }
    }
}
