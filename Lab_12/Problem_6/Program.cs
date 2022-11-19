using System;
using System.Text.RegularExpressions;

namespace Problem_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter key word: ");
            string keyWord = Console.ReadLine();

            string line = "This is my cat! And this is my dog. We happily live in Paris – the most beautiful city in the world! Isn’t it great? Well it is :)";
            Regex regex = new Regex($@"[A-Z](([a-z,A-Z,0-9])*(\s|\,|\-)*)*{keyWord}(([a-z,A-Z,0-9])*(\s|\,|\-)*)*(\.|\?|\!)");

            MatchCollection matchCollection = regex.Matches(line);

            foreach(Match match in matchCollection)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
