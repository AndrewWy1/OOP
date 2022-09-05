using System;

namespace Problem_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sbyte first = -100;
            byte second = 128;
            short third = -3540;
            ushort fourth = 64876;
            uint fifth = 2147483648;
            int sixth = -1141583228;
            long seventh = -1223372036854775808;

            Console.WriteLine(
                $"first: {first}\n" +
                $"second: {second}\n" +
                $"third: {third}\n" +
                $"fourth: {fourth}\n" +
                $"fifth: {fifth}\n" +
                $"sixth: {sixth}\n" +
                $"seventh: {seventh}");
        }
    }
}
