using System;

namespace Problem_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ferrari ferrari = new Ferrari();
            ferrari.Driver = Console.ReadLine();
            Console.WriteLine(ferrari.GetFullInfo());
        }
    }
}
