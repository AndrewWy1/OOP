using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_5._6
{
    internal class Pet : IBirthdate
    {
        private string _name;
        private Date _bornYear;

        public Pet(string name, Date birthdate)
        {
            this.Name = name;
            this.BornYear = birthdate;
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
            return $"Name: {this.Name}, Birthdate: {this.BornYear.GetDate()}";
        }
    }
}
