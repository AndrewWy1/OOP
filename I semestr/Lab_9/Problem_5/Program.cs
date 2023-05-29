using System;
using System.Collections.Generic;
using System.Collections;

namespace Problem_5_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string str = "";
            int index, countIdentical = 0, countNotidentical = 0;


            while (str != "END")
            {
                Console.Write("Enter info about person: ");
                str = Console.ReadLine();

                string[] tmpArray = str.Split(" ");
                if(tmpArray.Length != 3)
                {
                    Console.WriteLine("Incorect input");
                    continue;
                }

                people.Add(new Person(tmpArray[0], Int32.Parse(tmpArray[1]), tmpArray[2]));
            }

            Console.Write("Enter persons index: ");
            index = Int32.Parse(Console.ReadLine())-1;
            while (index > people.Count)
            {
                Console.Write("Enter persons index: ");
                index = Int32.Parse(Console.ReadLine());
            }
            Person checkPerson = people[index];

            foreach (Person person in people)
            {
                if (person.CompareTo(checkPerson) == 1)
                {
                    countIdentical++;
                }
                else
                    countNotidentical++;
            }

            if (countIdentical > 1)
                Console.WriteLine($"{countIdentical}, {countNotidentical}, {people.Count}");

            else
                Console.WriteLine("No matches");


            //Problem 6

            //SortedSet<Person> peopleName = new SortedSet<Person>(new PersonComparerName());
            //SortedSet<Person> peopleAge = new SortedSet<Person>(new PersonComparerAge());

            //Console.Write("Enter count of persons: ");
            //int count = Int32.Parse(Console.ReadLine());
            //string input;


            //for (int i = 0; i < count; i++)
            //{
            //    Console.Write("Enter person's date: ");
            //    input = Console.ReadLine();

            //    string[] tmpArray = input.Split(" ");

            //    if (tmpArray.Length != 2)
            //    {
            //        Console.WriteLine("Incorect input!");
            //        count++;
            //        continue;
            //    }
                    

            //    Person person = new Person(tmpArray[0], Int32.Parse(tmpArray[1]));
            //    peopleName.Add(person);
            //    peopleAge.Add(person);
            //}

            //Console.WriteLine("\nSorted by name: ");
            //foreach (Person person in peopleName)
            //{
            //    Console.WriteLine(person);
            //}

            //Console.WriteLine("\nSorted by age: ");
            //foreach (Person person in peopleAge)
            //{
            //    Console.WriteLine(person);
            //}
        }
    }
}
