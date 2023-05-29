using System;

namespace Problem_1
{
    internal class Person
    {
        private string name;
        private int age;

        public string Name;
        public int Age;

        static void Main(string[] args)
        {
            Person p = new Person();
            p.Name = Console.ReadLine();
            p.Age = 20;

            Person p2 = new Person();
            p2.Name = "Gosho";
            p2.Age = 18;

            Person p3 = new Person();
            p3.Name = "Stamat";
            p3.Age = 43;

            Console.WriteLine($"first: {p.Name}");
            Console.WriteLine($"first: {p.Age}");
            Console.WriteLine($"second: {p2.Name}");
            Console.WriteLine($"second: {p2.Age}");
            Console.WriteLine($"third: {p3.Name}");
            Console.WriteLine($"third: {p3.Age}");
        }
    }
}