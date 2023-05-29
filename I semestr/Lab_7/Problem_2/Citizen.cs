using Problem_2;
using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_1
{
    internal class Citizen : IPerson, IBirthdate, IIdentifiable
    {
        private string _name;
        private int _age;
        private string _birthdate;
        private string _id;

        public string Name { get;}
        public int Age { get;}
        public string Birthdate { get;}
        public string Id { get;}

        public Citizen(string name, int age, string birthdate, string id)
        {
            this.Name = name;
            this.Age = age;
            this.Birthdate = birthdate;
            this.Id = id;
        }
    }
}
