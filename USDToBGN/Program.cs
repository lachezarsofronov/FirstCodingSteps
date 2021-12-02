using System;

namespace USDToBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            double usd = double.Parse(Console.ReadLine());
            const double course = 1.79549;

            Console.WriteLine(course * usd);
        }
    }
}
