using Problem_5._6;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace Problem_5
{
    internal class Citizen : IPerson, IBirthdate
    {
        private string _id;
        private string _name;
        private int _age;
        private Date _bornYear;

        public Citizen(string name, int age, string id, Date birtdate)
        {
            this.ID = id;
            this.Name = name;
            this.Age = age;
            this.BornYear = birtdate;
        }

        public string ID
        {
            get { return _id; }
            set 
            {
                if (value.Length < 3) throw new Exception("ID is too small!");

                foreach (char c in value)
                    if (Char.IsLetter(c) || Char.IsSymbol(c))
                        throw new Exception("The ID cannot includes letter or symbol!");

                _id = value;
            }
        }
        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0)
                    throw new Exception("Age cannot be negative");
                
                _age = value;
            }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                foreach (char c in value)
                    if (Char.IsNumber(c) || Char.IsSymbol(c))
                        throw new Exception("The NAme cannot includes numbers or symbol!");

                _name = value;
            }
        }

        public Date BornYear
        {
            get { return _bornYear; }
            set { _bornYear = value; }
        }

        public string GetFullInfo()
        {
            return $"Name: {this.Name}, Age: {this.Age}, ID: {this.ID}, Birthdate: {this.BornYear.GetDate()}";
        }
    }
}
