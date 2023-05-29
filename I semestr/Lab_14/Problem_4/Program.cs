using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Problem_4
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
                if (input.Length == 2)
                {
                    list.Add(new Student(input[0], input[1]));
                }

                Console.Write("Enter info about person: ");
                input = Console.ReadLine().Split(" ");
            }

            var SortSrudent = list.OrderBy(s => s.LastName).ThenByDescending(s => s.Name);

            foreach(Student s in SortSrudent)
            {
                Console.WriteLine(s);
            }
        }
    }
}
