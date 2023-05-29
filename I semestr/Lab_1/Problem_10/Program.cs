using System;

namespace Problem_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int lastDigit = n % 10;
            Console.WriteLine(lastDigit);
            
        }
    }
}
