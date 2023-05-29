using System;

namespace Problem_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ModelPhone modelPhone = new ModelPhone();

            modelPhone.CallingAllNumbers(modelPhone.
                SetNumbers("088234215 0882134333 08992134215 0558123 3333 1h"));

            modelPhone.BrowseAllSites(modelPhone.
               SetSites("http://softuni.bg http://youtube.com http://www.g00gle.com"));
        }
    }
}
