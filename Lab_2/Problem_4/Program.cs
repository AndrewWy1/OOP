using System;

namespace Problem_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine()), count = 0;

            while(number <= 1)
            {
                Console.WriteLine("Enter the number: ");
                number = Convert.ToInt32(Console.ReadLine());
            }

            int[] array = new int[(int)Math.Sqrt(number)];

            Console.WriteLine("Numbers: " + String.Join(", ", array));
        }
    }
}
