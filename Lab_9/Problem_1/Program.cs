using System;

namespace Problem_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> list;
            string[] array = new string[10];
            string input = "";

            Console.Write("Enter elements: ");
            input = Console.ReadLine();
            array = input.Split(" ");
            list = new MyList<string>(array);

            while (input != "END")
            {
                Console.Write("Enter your commands: ");
                input = Console.ReadLine();

                switch (input) 
                {
                    case "HasNext":
                        Console.WriteLine(list.HasNext());
                        break;

                    case "Move":
                        Console.WriteLine(list.MoveNext());
                        break;

                    case "Print":
                        Console.WriteLine(list.ReturnValue());
                        break;

                    case "PrintAll":
                        foreach(string item in list)
                        {
                            Console.Write(item + " ");
                        }
                        Console.WriteLine();
                        break;

                    default:
                        Console.WriteLine("Incorect input");
                        break;
                }
            }
        }
    }
}
