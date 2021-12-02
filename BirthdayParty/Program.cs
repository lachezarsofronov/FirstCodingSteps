using System;

namespace BirthdayParty
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            double hallRent =  double.Parse(Console.ReadLine());

            // • Торта  – цената ѝ е 20% от наема на залата
            // • Напитки – цената им е 45 % по - малко от тази на тортата
            // • Аниматор – цената му е 1 / 3 от цената за наема на залата

            // calc prices
            double cakePrice = hallRent * 0.20;
            double drinksPrice = cakePrice * 0.55;
            double animatorPrice = hallRent / 3;

            // calc total costs
            double finalPrice = hallRent + cakePrice + drinksPrice + animatorPrice;

            //output
            Console.WriteLine(finalPrice);
        }
    }
}
