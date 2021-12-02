using System;

namespace SummerBooksToRead
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int pages = int.Parse(Console.ReadLine());
            double pagesCanReadPerHour = double.Parse(Console.ReadLine());
            int daysMustRead = int.Parse(Console.ReadLine());

            // calc total time needed to finish the book
            double totalTime = (pages / pagesCanReadPerHour) / daysMustRead;

            //output
            Console.WriteLine(totalTime);
        }
    }
}
