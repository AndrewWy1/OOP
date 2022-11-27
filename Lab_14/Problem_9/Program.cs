
using Problem_7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Problem_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>();

            string[] input;
            List<int> marks = new List<int>();

            Console.Write("Enter info about person: ");
            input = Console.ReadLine().Split(" ");

            Console.Write("Enter marks: ");
            marks = Console.ReadLine().Split(" ").Select(Int32.Parse).ToList();

            while (true)
            {
                if (input.Length == 1)
                {
                    list.Add(new Student(input[0], marks));
                }

                Console.Write("Enter info about person: ");
                input = Console.ReadLine().Split(" ");
                if (input[0] == "END") break;

                Console.Write("Enter marks: ");
                marks = Console.ReadLine().Split(" ").Select(Int32.Parse).ToList();
            }

            Regex regex = new Regex("(14|15)\\s?$");
            var StudentsYear = list.Where(s => regex.IsMatch(s.FacultyNumber));

            foreach(var s in StudentsYear)
            {
                Console.WriteLine(s);
            }
        }
    }
}
