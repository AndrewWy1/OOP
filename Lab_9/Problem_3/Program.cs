using System;
using System.Transactions;

namespace Problem_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            string str = "";

            while(str != "END")
            {
                Console.Write("Enter your commands: ");
                str = Console.ReadLine();

                switch (str) 
                {
                    case "Push":
                        Console.Write("Enter elements: ");
                        str = Console.ReadLine();
                        
                        string[] tmpArray = str.Split(" ");
                        for(int i = 0; i < tmpArray.Length; i++)
                        {
                            stack.Push(Convert.ToInt32(tmpArray[i]));
                        }
                        break;

                    case "Pop":
                        Console.WriteLine(stack.Pop());
                        break;
                    
                    default:
                        Console.WriteLine("Invalid command!");
                        break;
                }

            }
        }
    }
}
