using System;

namespace YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            // Цената на един кв. м. е 7.61лв със ДДС
            // 18 % отстъпка от крайната цена.

            //input
            double squareMetersForGreening = double.Parse(Console.ReadLine());

            //calc total price
            double finalPrice = squareMetersForGreening * 7.61;

            //discount
            double discount = finalPrice * 0.18;

            // finalPrice after the discount
            finalPrice -= discount;

            //output
            Console.WriteLine($"The final price is: {finalPrice} lv.");
            
            Console.WriteLine($"The discount is: {discount} lv.");

        }
    }
}
