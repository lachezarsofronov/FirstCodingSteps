using System;

namespace ZooStore
{
    class Program
    {
        static void Main(string[] args)
        {
            // храната за кучета е на цена 2.50лв., а всяка друга, която не е за тях струва 4лв.
            //input
            int dogsCount = int.Parse(Console.ReadLine());
            int otherAnimalsCount = int.Parse(Console.ReadLine());

            // calculating the total price
            double finalPrice = dogsCount * 2.5 + otherAnimalsCount * 4;

            //output
            Console.WriteLine($"{finalPrice} lv.");
        }
    }
}
