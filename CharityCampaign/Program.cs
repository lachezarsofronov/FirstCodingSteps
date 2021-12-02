using System;

namespace CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int campaignDays = int.Parse(Console.ReadLine());
            int cookersCount = int.Parse(Console.ReadLine());
            int cakeCount = int.Parse(Console.ReadLine());
            int gophretCount = int.Parse(Console.ReadLine());
            int pancakesCount = int.Parse(Console.ReadLine());

            //•	Торта - 45 лв.
            //•	Гофрета - 5.80 лв.
            //•	Палачинка – 3.20 лв.

            // 1 / 8 от крайната сума ще бъде използвана за покриване на разходите за продуктите по време на кампанията. 

            // calc prices
            double cakePrice = cakeCount * 45;
            double gophretPrice = gophretCount * 5.80;
            double pancakesPrice = pancakesCount * 3.20;

            // calc total prices for all cookers
            double totalPricePerDay = (cakePrice + gophretPrice + pancakesPrice) * cookersCount;

            // calc total profit
            double totalPrice = totalPricePerDay * campaignDays;

            // calc costs
            double costs = totalPrice / 8;

            //output => total profit after costs
            Console.WriteLine(totalPrice - costs);
        }
    }
}
