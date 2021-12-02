using System;

namespace InchToSm
{
    class Program
    {
        static void Main(string[] args)
        {
            const double InchToSm = 2.54; // 1 inch = 2.54 sm.  => const

            // input in inches
            double inches = double.Parse(Console.ReadLine());
          
            // print result in sm.
            Console.WriteLine(inches * InchToSm);
        }
    }
}
