using System;

namespace Problem_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine()),
                n = Convert.ToInt32(Console.ReadLine());

            double nDigit = Math.Truncate(number / Math.Pow(10, --n)) % 10;
            Console.WriteLine(nDigit);
        }
    }
}
