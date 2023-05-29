using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_5
{
    internal class Robot : IPerson
    {
        private string _id;
        private string _model;

        public Robot(string model, string id)
        {
            this.ID = id;
            this.Name = model;
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
        public string Name 
        {
            get { return _model; }
            set {_model = value; } 
        }

        public string GetFullInfo()
        {
            return $"Name: {this.Name}, ID: {this.ID}";
        }
    }
}
