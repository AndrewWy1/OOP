using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Problem_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string emails = "Many users @ SoftUni confuse email addresses.\r\nWe @ Softuni.BG provide high-quality training @\r\nhome or @ class. –- steve.parker@softuni.de.\r\n";
            Regex regex = new Regex(@"(\s|^)([a-z,0-9])+\W*([a-z,0-9])+@(([a-z,0-9]+[_,-]*[a-z,0-9]+)\.([a-z,0-9]+[_,-]*[a-z,0-9]+\.?)*)\w+");

            MatchCollection matches = regex.Matches(emails);

            foreach(Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
