using System;

namespace Problem_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = 1, last = 1, size;

            Console.WriteLine("Enter size: ");
            size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];

            Console.WriteLine("Write elemenys: ");
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(array);
            int item = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == array[i - 1])
                {
                    start++;
                }
                else
                {
                    start = 1;
                }
                if (start > last)
                {
                    last = start;
                    item = array[i - 1];
                }
            }
            Console.WriteLine($"Max item: {item}");
        }
    }
}
