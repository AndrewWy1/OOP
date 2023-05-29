using Problem_7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Markup;

namespace Problem_10
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

            while (true)
            {
                if (input.Length == 3)
                {
                    list.Add(new Student(input[0], input[1], Convert.ToInt32(input[2])));
                }

                Console.Write("Enter info about person: ");
                input = Console.ReadLine().Split(" ");
                if (input[0] == "END") break;
            }

            var GroupStudentsByGroupNumber = list.GroupBy(s => s.Group).OrderBy(g => g.Key);

            foreach(var group in GroupStudentsByGroupNumber)
            {
                Console.Write($"{group.Key} - ");

                foreach(var person in group)
                {
                    Console.Write($"{person.FirstName} {person.LastName}, ");
                }
                Console.WriteLine();
            }
        }
    }
}
