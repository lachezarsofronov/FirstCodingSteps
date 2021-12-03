using System;

namespace FishMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            double mackerelPricePerKg = double.Parse(Console.ReadLine());
            double spratPricePerKg = double.Parse(Console.ReadLine());
            double bonitoInKg = double.Parse(Console.ReadLine());
            double horseMackerelInKg = double.Parse(Console.ReadLine());
            int clamsInKg = int.Parse(Console.ReadLine());

            //•	Паламуд – 60 % по - скъп от скумрията
            //•	Сафрид – 80 % по - скъп от цацата
            //•	Миди – 7.50 лв.за килограм


            //calc prices
            double clamsPrice = clamsInKg * 7.50;
            double bonitoPrice = (mackerelPricePerKg + mackerelPricePerKg * 0.60) * bonitoInKg;
            double horseMackerelPrice = (spratPricePerKg + spratPricePerKg * 0.80) * horseMackerelInKg;

            double finalPrice = clamsPrice + bonitoPrice + horseMackerelPrice;


            //output
            Console.WriteLine($"{finalPrice:F2}");
        }
    }
}
