using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the world: ");

            char[] charArray = Console.ReadLine().ToCharArray();
            char[] reverseCharArray = new char[charArray.Length]; 

            for(int i = charArray.Length-1, y = 0; i >= 0; i--, y++)
            {
                reverseCharArray[y] = charArray[i];
            }

            string reverseString = String.Join("", reverseCharArray);
            Console.WriteLine($"Reverse: {reverseString}");
        }
    }
}
