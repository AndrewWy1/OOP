using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_5._6
{
    internal class BirthdateCheck
    {
        private List<IBirthdate> _persons = new List<IBirthdate>();
        private int _controlYear;

        public int ControlYear
        {
            get { return _controlYear; }

            set
            {
                if (value < 0)
                    throw new Exception("The control year cannot be negative!");

                _controlYear = value;
            }
        }
        public void AddToList(string info)
        {
            string[] infoArray = info.Split(' ');

            if (infoArray.Length == 2)
                _persons.Add(new Pet(infoArray[0], new Date(infoArray[1])));

            if (infoArray.Length == 4)
                _persons.Add(new Citizen(infoArray[0], Convert.ToInt32(infoArray[1]), infoArray[2], new Date(infoArray[3])));
        }

        public void CheckBirthdates()
        {
            int tmpYear;
            foreach (IBirthdate person in _persons)
            {
                tmpYear = person.BornYear.Year;
                if (tmpYear == ControlYear)
                    Console.WriteLine($"Arrest: {person.GetFullInfo()}");
            }
        }
    }
}
