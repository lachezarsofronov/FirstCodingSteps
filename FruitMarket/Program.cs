using System;

namespace FruitMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            double strawberryPrice = double.Parse(Console.ReadLine());
            double banannasKG = double.Parse(Console.ReadLine());
            double orangesKG = double.Parse(Console.ReadLine());
            double raspberriesKG = double.Parse(Console.ReadLine());
            double strawberryKG = double.Parse(Console.ReadLine());


            // calc fruits price

            //•	цената на малините е на половина по - ниска от тази на ягодите;
            //•	цената на портокалите е с 40 % по - ниска от цената на малините;
            //•	цената на бананите е с 80 % по - ниска от цената на малините.

            double raspberryPrice = strawberryPrice / 2;
            double orangesPrice = raspberryPrice * 0.60;
            double banannasPrice = raspberryPrice * 0.20;

            // calc total price
            double finalPrice = strawberryPrice * strawberryKG + banannasKG * banannasPrice + orangesKG * orangesPrice + raspberryPrice * raspberriesKG;


            //output
            Console.WriteLine($"{finalPrice:F2}");
        }
    }
}
