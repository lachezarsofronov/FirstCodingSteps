using System;

namespace USDToBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            double usd = double.Parse(Console.ReadLine());

            // 1 USD = 1.79549 BGN.
            const double course = 1.79549;

            //output
            Console.WriteLine(course * usd);
        }
    }
}