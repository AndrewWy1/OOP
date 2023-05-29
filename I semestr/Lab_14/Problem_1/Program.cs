using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();

            string[] input;

            Console.Write("Enter info about person: ");
            input = Console.ReadLine().Split(" ");

            while (input[0] != "END")
            {
                if (input.Length == 3)
                {
                    list.Add(new Person(input[0], input[1], Convert.ToInt32(input[2])));
                }

                Console.Write("Enter info about person: ");
                input = Console.ReadLine().Split(" ");
            }


            var groupPerson = list.Where(p => p.Group == 2).OrderBy(p => p.Name);

            foreach (var person in groupPerson)
            {
                Console.WriteLine(person);
            }

            Console.WriteLine("\n\n\n");

            var GroupName = list.Where(p => p.Name.CompareTo(p.Lastname) < 0).OrderBy(p => p.Name);

            foreach (var person in GroupName)
            {
                Console.WriteLine(person);
            }
        }
    }
}
