using System;

namespace TriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            // area = a * h / 2. 

            double area = a * h / 2;

            //output
            Console.WriteLine($"{area:F2}");
        }
    }
}
