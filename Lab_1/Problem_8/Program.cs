using System;

namespace Problem_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short a = Convert.ToInt16(Console.ReadLine()), 
                b = Convert.ToInt16(Console.ReadLine()), 
                c = Convert.ToInt16(Console.ReadLine());

            float average = (a+b+c) / 3.0F;

            Console.WriteLine(average);
        }
    }
}
