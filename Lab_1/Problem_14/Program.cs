using System;

namespace Problem_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine()), 
                b = Convert.ToInt32(Console.ReadLine()), 
                c = Convert.ToInt32(Console.ReadLine());

            int result = (a > b && a > c) ? a : (b > a && b > c) ? b : c;
            Console.WriteLine(result);
        }
    }
}
