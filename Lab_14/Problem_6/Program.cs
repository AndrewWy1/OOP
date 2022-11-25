using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Problem_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>();

            string[] input;

            Console.Write("Enter info about person: ");
            input = Console.ReadLine().Split(" ");

            while (input[0] != "END")
            {
                if (input.Length == 3)
                {
                    list.Add(new Student(input[0], input[1], input[2]));
                }

                Console.Write("Enter info about person: ");
                input = Console.ReadLine().Split(" ");
            }
            Regex regex = new Regex("^(\\+3592|02)");
            var StrudentsEmail = list.Where(s => regex.IsMatch(s.Phone));

            foreach (var s in StrudentsEmail)
            {
                Console.WriteLine(s);
            }
        }
    }
}
