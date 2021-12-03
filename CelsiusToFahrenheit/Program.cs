using System;

namespace CelsiusToFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            double Celsius = Double.Parse(Console.ReadLine());

            //transorm C to F

            double Fahrenheit = (Celsius * 1.8) + 32;

            //output
            Console.WriteLine($"{Fahrenheit:F2}");
        }
    }
}
