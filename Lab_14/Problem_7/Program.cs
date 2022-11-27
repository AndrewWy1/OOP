using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Problem_7
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
                if (input.Length == 2)
                {
                    list.Add(new Student(input[0], input[1], marks));
                }

                Console.Write("Enter info about person: ");
                input = Console.ReadLine().Split(" ");
                if (input[0] == "END") break;

                Console.Write("Enter marks: ");
                marks = Console.ReadLine().Split(" ").Select(Int32.Parse).ToList();
            }
            var StudentsExexcellentGrades = list.Where(s => s.Marks.Any(num => num == 6));
            foreach (var s in StudentsExexcellentGrades)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("\n\n\n");

            var StudentsCountGrades = list.Where(s => s.Marks.Count(num => num <= 3) >= 2);
            foreach (var s in StudentsCountGrades)
            {
                Console.WriteLine(s);
            }

        }
    }
}
