using System;
using System.Transactions;

namespace Problem_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine()),
                b = Convert.ToDouble(Console.ReadLine()),
                h = Convert.ToDouble(Console.ReadLine());

            double Area = (a + b) / 2 * h;
            Console.WriteLine(Area);
        }
    }
}
