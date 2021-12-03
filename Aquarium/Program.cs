using System;

namespace Aquarium
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int lenghtSM = int.Parse(Console.ReadLine());
            int widthSM = int.Parse(Console.ReadLine());
            int heighSM = int.Parse(Console.ReadLine());
            double percentStuff = double.Parse(Console.ReadLine());

            //calc total dimensions
            double dimensions = lenghtSM * widthSM * heighSM;
            dimensions *= 0.001; // transform dimensions in liters

            percentStuff *= 0.01; //transform input % into %

            //calc total water in liters needed to fill up the aquarium
            double neededWaterLiters = dimensions - dimensions * percentStuff;

            //output
            Console.WriteLine(neededWaterLiters);
        }
    }
}
