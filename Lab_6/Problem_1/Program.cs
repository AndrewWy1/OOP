using System;

namespace Problem_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Ivan", 44);
            Console.WriteLine(person.getFullInfo());

            Child child = new Child("Max", 16);
            Console.WriteLine(child.getFullInfo());
        }
    }
}
