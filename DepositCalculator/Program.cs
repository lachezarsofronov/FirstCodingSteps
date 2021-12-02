using System;

namespace DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            double deposit = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double annualTaxPercent = double.Parse(Console.ReadLine());

            //calc totall tax
            double totalTax = deposit * annualTaxPercent / 100;

            //calc one month Tax
            double taxPerMonth = totalTax / 12;

            //calc final price
            double finalPrice = deposit + (months * taxPerMonth); 

            //output
            Console.WriteLine(finalPrice);
        }
    }
}
