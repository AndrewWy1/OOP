using System;

namespace Problem_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            bool result = n > 20 && n % 2 != 0;
            Console.WriteLine(result);
        }
    }
}
