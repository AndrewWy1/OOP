using System;
namespace Problem_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = 1, last = 1, tempOutput = 0, size;

            Console.WriteLine("Enter array size: ");
            size = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[size];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1])
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
                    tempOutput = array[i];
                }
            }

            Console.WriteLine("Max Sequence of Equal Elements:");
            for (int i = 0; i < last; i++)
            {
                Console.Write("{0} ", tempOutput);
            }
        }
    }
 
}
