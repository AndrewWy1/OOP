using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

namespace Problem_4
{
    class Person
    {
        public string name;
        public int age;
        public string info = "";
        public static List<Person> listOfPersons = new List<Person>();

        public void infoAboutPerson()
        {
            Console.Write("Enter number of lines: ");
            int N = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                info += Console.ReadLine() + "\n";
            }
        }

        public static void personsOver30()
        {
            List<Person> persons30 = new List<Person>();

            foreach(Person pers in listOfPersons)
            {
                if (pers.age > 30) persons30.Add(pers);
            }

            persons30.Sort((x, y) => x.name.CompareTo(y.name));

            foreach (Person pers in persons30)
            {
                Console.WriteLine($"{pers.name} {pers.age}");
            }
        }

        public Person()
        {
            name = "No name";
            age = 1;
            listOfPersons.Add(this);
        }
        public Person(int personAge)
        {
            name = "No name";
            age = personAge;
            listOfPersons.Add(this);
        }
        public Person(string personName, int personAge)
        {
            name = personName;
            age = personAge;
            listOfPersons.Add(this);
        }
}

    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(5);
            Person person1 = new Person("Nikolai", 33);
            Person person2 = new Person("Yordan", 88);
            Person person3 = new Person("Tosho", 22);
            Person person4 = new Person("Lyubo", 44);
            Person person5 = new Person("Stanislav", 11);

            Person.personsOver30();
        }
    }
}
