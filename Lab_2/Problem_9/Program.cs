using System;
using System.Diagnostics.Tracing;

namespace Problem_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "abcdefghijklmnopqrstuvwxyz0123456789", word;
            word = Console.ReadLine();
            for (int i = 0; i < word.Length; i++)
            {
                for(int j = 0; j < text.Length; j++)
                {
                    if (word[i] == text[j]) Console.WriteLine($"{word[i]} => {j}");
                }
            }
        }
    }
}
