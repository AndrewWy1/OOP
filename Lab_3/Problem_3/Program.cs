using System;
using System.Collections.Generic;

namespace Problem_3
{
    class Person
    {
        public string name;
        public int age;

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
    }
    class Family
    {
        public List<Person> listOfPerson = new List<Person>();
        public void addMember(Person member)
        {
            listOfPerson.Add(member);
        }
        
        public void getOldestMember()
        {
            Person oldMember = listOfPerson[0];

            foreach( Person member in listOfPerson)
            {
                if(member.age > oldMember.age)
                {
                    oldMember = member;
                }
            }

            Console.WriteLine($"Oldest persond is {oldMember.name}, {oldMember.age} years old");
        }
    }

    internal class Program
    {
        static void Main()
        {
            Person person1 = new Person(5);
            Person person2 = new Person("Steve", 10);
            Person person3 = new Person("Christopher", 15);
            Person person4 = new Person("Annie", 4);
            Person person5 = new Person("Ivan", 35);
            Person person6 = new Person("Maria", 34);

            Family family = new Family();

            family.addMember(person1);
            family.addMember(person2);
            family.addMember(person3);
            family.addMember(person4);
            family.addMember(person5);
            family.addMember(person6);

            family.getOldestMember();
        }
    }
}
