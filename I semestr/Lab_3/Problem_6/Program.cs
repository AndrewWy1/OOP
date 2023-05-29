using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Problem_6
{
    class Employee
    {
        private string name;
        private double salary;
        private string position;
        private string departament;
        private string email;
        private int age;


        public Employee(string Name, double Salary, string Position, string Departament, string Email = "n/a", int Age = -1)
        {
            name = Name;
            salary = Salary;
            position = Position;
            departament = Departament;
            email = Email;
            age = Age;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of strings");
            int number = Convert.ToInt32(Console.ReadLine());

            List<Employee> staff = new List<Employee>(number);

            string[] infoAboutStaffArray = new string[6];
            string Name, Position, Departament, Email;
            double Salary;
            int Age;
            string str = Convert.ToString(Console.ReadLine());
            //infoAboutStaffArray = str.Split(" ");

            Console.WriteLine(infoAboutStaffArray);
            //for (int i = 0; i < staff.Count; i++)
            //{
                


            //    staff[i] =  new Employee();
            //}
        }


    }
}
