using System;

namespace TrapezoidArea
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            double b1 = double.Parse(Console.ReadLine());
            double b2 = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            // (b1 + b2) * h / 2.

            double area = (b1 + b2) * h / 2;

            //output
            Console.WriteLine($"{area:F2}");
        }
    }
}
