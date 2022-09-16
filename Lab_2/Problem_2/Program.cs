using System;
using System.Linq;
using System.Reflection.Emit;
using System.Threading.Tasks.Dataflow;

namespace Problem_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k, n;

            Console.WriteLine("Enter the length of array: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number of rotate(max 2): ");
            k = Convert.ToInt32(Console.ReadLine());

            int[] array1 = new int[n];
            Console.WriteLine("Enter elements of array =>");

            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
