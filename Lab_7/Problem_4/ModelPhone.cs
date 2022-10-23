using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_4
{
    internal class ModelPhone : ISearching, Icalling
    {
        private List<string> _numberList = new List<string>();
        private List<string> _browsingList = new List<string>();
        private string invalidSite = "Invalid URL!";
        private string invalidNumber = "Invalid number!";

        public string[] SetNumbers(string listNumbers)
        {
            string[] numbers = listNumbers.Split(' ');

            for (int i = 0; i < numbers.Length; i++)
            {
                try
                {
                    foreach (char symbol in numbers[i])
                        if (Char.IsLetter(symbol))
                            throw new Exception();
                }
                catch
                {
                    numbers[i] = invalidNumber;
                }
            }

            return numbers;
        }

        public string[] SetSites(string listSites)
        {
            string[] sites = listSites.Split(' ');

            for (int i = 0; i < sites.Length; i++)
            {
                try
                {
                    foreach (char symbol in sites[i])
                        if (Char.IsNumber(symbol))
                            throw new Exception();
                }
                catch
                {
                    sites[i] = invalidSite;
                }
            }

            return sites;
        }

        public void BrowseAllSites(string[] sites)
        {
            foreach(string site in sites){
                if (site == invalidSite)
                    Console.WriteLine(invalidSite);
                else
                    Console.WriteLine($"Browsing: {site}");
            }
        }

        public void CallingAllNumbers(string[] numbers)
        {
            foreach (string number in numbers)
            {
                if (number == invalidNumber)
                    Console.WriteLine(invalidNumber);
                else
                    Console.WriteLine($"Calling... {number}");
            }
        }
    }
}
