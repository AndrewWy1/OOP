using System;

namespace Problem_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human("Ivan", "Kaplan");
            Console.WriteLine(human.getFullInfo());
            Console.Write("\n\n");

            Student student = new Student("Petro", "Kobevko", "08000");
            Console.WriteLine(student.getFullInfo());
            Console.Write("\n\n");

            Worker worker = new Worker("Nastya", "Pyrogova", 1590, 10);
            Console.WriteLine(worker.getFullInfo());
        }
    }
}
