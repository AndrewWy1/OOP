using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Problem_5._6
{
    public class Date
    {
        private int _day;
        private int _month;
        private int _year;

        public Date(string data)
        {
            this.SetDate(data);
        }

        public int Day
        {
            get { return _day; }

            set
            {
                if(value < 1 || value > 31)
                    throw new Exception("A day cannot be less than 1 and greater than 31");

                _day = value;
            }
        }

        public int Month
        {
            get { return _month; }

            set
            {
                if (value < 1 || value > 12)
                    throw new Exception("A month cannot be less than 1 and greater than 12");

                _month = value;
            }
        }

        public int Year
        {
            get { return _year; }

            set 
            {
                if (value < 0)
                    throw new Exception("A year cannot be negative");

                _year = value;
            }
        }


        public void SetDate(string date)
        {
            string[] dateParts = date.Split('/');

            this.Day = Int32.Parse(dateParts[0]);
            this.Month = Int32.Parse(dateParts[1]);
            this.Year = Int32.Parse(dateParts[2]);
        }

        public string GetDate()
        {
            return $"{this.Day}/{this.Month}/{this.Year}";
        }
    }
}
