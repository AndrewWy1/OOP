using System;

namespace Problem_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, count;

            Console.Write("Enter n: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n Output:\n");

            for (int i = 2; i < n; i++)
            {
                count = 0;
                for (int j = 2; j < i; j++)
                {
                    if (i % 2 == 0)
                    {
                        count++;
                    }
                }

                if (count== 0 && i != 1)
                {
                    Console.WriteLine($"{i}");
                }
            }
        }
    }
}
