using Problem_5._6;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Markup;

namespace Problem_5
{
    internal class IDChekc
    {
        private List<IPerson> _persons = new List<IPerson>();
        private string _controlID;
        
        public string ControlID 
        { 
            get { return _controlID; } 

            set 
            { 
                if(value.Length > 3) 
                    throw new Exception("The control ID can includes only 3 digits!");

                foreach(char c in value)
                {
                    if (Char.IsLetter(c) || Char.IsSymbol(c))
                        throw new Exception("Thre control ID cannot includes letter or symbol!");
                }

                _controlID = value;
            }
        }
        public void AddToList(string info)
        {
            string[] infoArray = info.Split(' ');

            if (infoArray.Length == 2)
                _persons.Add(new Robot(infoArray[0], infoArray[1]));

            if (infoArray.Length == 4)
                _persons.Add(new Citizen(infoArray[0], Convert.ToInt32(infoArray[1]), infoArray[2], new Date(infoArray[3])));
        }
 
        public void CheckPersons()
        {
            string tmpID;
            foreach(IPerson person in _persons)
            {
                tmpID =  person.ID.Substring(person.ID.Length - 3);
                if (tmpID == ControlID)
                    Console.WriteLine($"Arrest: {person.GetFullInfo()}");
            }
        }
    }
}
