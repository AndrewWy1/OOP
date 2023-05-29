
using System;

namespace Problem_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("1984", "George Orwell", 20.00);
            Console.WriteLine(book.GetFullInfo());

            GoldenEditonBook goldenEditonBook = new GoldenEditonBook("1984", "George Orwell", 20.00);
            Console.WriteLine(goldenEditonBook.GetFullInfo());
        }
    }
}
