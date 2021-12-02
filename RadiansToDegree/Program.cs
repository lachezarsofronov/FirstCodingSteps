using System;

namespace RadiansToDegree
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            double radians = double.Parse(Console.ReadLine());

            //convert to degree
            double degree = radians * 180 / Math.PI;  //градус = радиан * 180 / π

            //output
            Console.WriteLine(Math.Round(degree));
        }
    }
}
