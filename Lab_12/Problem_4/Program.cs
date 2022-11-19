
using System;
using System.Text.RegularExpressions;

namespace Problem_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = "<ul> <li> <a href=\"http://softuni.bg\">SoftUni</a> </li> </ul>";
            Regex regex = new Regex("<a\\shref=((\\'|\\\")([a-z,0-9]|\\:|\\/)*(\\.[a-z]*)(\\'|\\\"))>(.*\\s?)<\\/a>");

            line = regex.Replace(line, "[URL href=$1>$6[/URL]");

            Console.Write(line);


        }
    }
}
