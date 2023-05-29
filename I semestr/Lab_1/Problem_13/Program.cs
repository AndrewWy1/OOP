using System;

namespace Problem_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            bool result = n % 9 == 0 || n % 11 == 0 || n % 13 == 0;
            Console.WriteLine(result);
        }
    }
}
