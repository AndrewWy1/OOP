using Problem_5._6;
using System;
using System.Collections.Generic;

namespace Problem_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IDChekc idChekc = new IDChekc();
            //string tmpInput;

            //Console.Write("Enter info about person (Name, age(if human), id, birthdate(id human): ");
            //tmpInput = Console.ReadLine();

            //while (tmpInput != "END")
            //{
            //    idChekc.AddToList(tmpInput);
            //    Console.Write("Enter info about person (Name, age(if human), id, birthdate(id human)): ");
            //    tmpInput = Console.ReadLine();
            //}

            //Console.Write("Enter Control ID: ");
            //idChekc.ControlID = Console.ReadLine();

            //Console.Write("\n\n");
            //idChekc.CheckPersons();



            BirthdateCheck birthdateCheck = new BirthdateCheck();
            string tmpInput;

            Console.Write("Enter info about person (Name, age(if human), id, birthdate): ");
            tmpInput = Console.ReadLine();

            while (tmpInput != "END")
            {
                birthdateCheck.AddToList(tmpInput);
                Console.Write("Enter info about person (Name, age(if human), idm birthdate): ");
                tmpInput = Console.ReadLine();
            }

            Console.Write("Enter control birthdate: ");
            birthdateCheck.ControlYear = Int32.Parse(Console.ReadLine());

            Console.Write("\n\n");
            birthdateCheck.CheckBirthdates();
        }
    }
}
