using System;

namespace WeatherForecast
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            String weather = Console.ReadLine();

            //output with condition
            if (weather == "sunny")
            {
                Console.WriteLine("It's warm outside!");
            }
            else
            {
                Console.WriteLine("It's cold outside!");
            }
        }
    }
}
