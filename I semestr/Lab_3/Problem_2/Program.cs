using System;

namespace Problem_2
{
    internal class Person
    {
        private string name;
        private int age;

        public string Name;
        public int Age;

        public Person()
        {
            name = "No name";
            age = 1;
        }
        public Person(int personAge)
        {
            name = "No name";
            age = personAge;
        }
        public Person(string personName, int personAge)
        {
            name = personName;
            age = personAge;
        }



        static void Main(string[] args)
        {
            Person per = new Person();
            Console.WriteLine($"{per.name}");
            Console.WriteLine($"{per.age}");

            Person per1 = new Person(18);
            Console.WriteLine($"{per1.name}");
            Console.WriteLine($"{per1.age}");

            Person per2 = new Person("Ivan", 19);
            Console.WriteLine($"{per2.name}");
            Console.WriteLine($"{per2.age}");
        }
    }
}
