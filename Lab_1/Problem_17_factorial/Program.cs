using System;

namespace Problem_17_factorial
{
    internal class Program
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            static int factorial(int n)
            {
                if (n == 1 || n == 0) return 1;

                return factorial(n - 1) * n;
            }
            Console.WriteLine(factorial(n));
        }
    }
}
