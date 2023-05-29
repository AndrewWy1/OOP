using System;

namespace Problem_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = new int[] { 13, 23, 1, -8, 4, 9 };

            Lake ints1 = new Lake(ints);

            Console.WriteLine(String.Join(", ", ints1));
        }
    }
}
