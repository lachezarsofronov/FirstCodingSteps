using System;

namespace GreetingsByName
{
    class Program
    {
        static void Main(string[] args)
        {
            // input var name
            string name = Console.ReadLine();

            //print formated string with var name;
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
