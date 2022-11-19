using System;
using System.Reflection.Emit;
using System.Text.RegularExpressions;

namespace Problem_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = "ivan ivanov Ivan Ivanov van ivanov Ivan ivanov ivan Ivanov IVan Ivanov IvanIvAnov Ivan Ivanov";
            Regex regex = new Regex(@"[A-Z][a-z]+\s[A-Z][a-z]+");
            MatchCollection matches = regex.Matches(line);

            foreach(Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
