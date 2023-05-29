using System;
using System.Text.RegularExpressions;

namespace Problem_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = "aaaaabbbbbcdddeeeedssaa";
            Regex regex = new Regex(@"(.)\1+");

            line = regex.Replace(line, "$1");

            Console.WriteLine(line);
        }
    }
}
