using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3
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
                    list.Add(new Student(input[0], input[1], Convert.ToInt32(input[2])));
                }

                Console.Write("Enter info about person: ");
                input = Console.ReadLine().Split(" ");
            }

            var StudentAge = list.Where(s => s.Age >= 18 && s.Age <= 24);

            foreach(var student in StudentAge)
            {
                Console.WriteLine(student);
            }
        }
    }
}
