using System;
using System.Text.RegularExpressions;

namespace Problem_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numbers = "+359 2 234 5678 +359-2-234-5678 +359-2 234-5678 +359 2 222 2222 +3591345123";
            Regex regex = new Regex(@"\+359(?<space>(\s|-))[0-9]{1}\k<space>[0-9]{3}\k<space>[0-9]{4}");

            MatchCollection matchCollection = regex.Matches(numbers);

            foreach(Match match in matchCollection)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
