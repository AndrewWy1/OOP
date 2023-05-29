using System;
using System.Diagnostics.Contracts;

namespace Problem_15
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double[] array = new double[3];
            int countOfNegativeNumbers = 0;

            for(int i = 0; i < 3; i++)
            {
                array[i] = Convert.ToDouble(Console.ReadLine());
                if (array[i] < 0) countOfNegativeNumbers++;
            }

            if(countOfNegativeNumbers == 1 || countOfNegativeNumbers == 3)
            {
                Console.WriteLine("Negative");
            }
            else
            {
                Console.WriteLine("Positive");
            }
        }
    }
}
