using System;

namespace Problem_17
{
    internal class Program
    {
      
  
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine()), factorial = 1;

            for(int i = 2; i <= n; i++)
            {
                factorial *= i;
            }

            Console.WriteLine(factorial);
        }
        
        
    }
}
