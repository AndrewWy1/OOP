using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using Problem_1.Classes;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Diagnostics;

namespace Problem_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string connectionString = "Server=WINDOWS-8NR2C06\\SQLEXPRESS;Database=newsletters_promotional_product;Trusted_Connection=true;Encrypt=false";

            AllBuyers(connectionString);
            Emails(connectionString);
            Section(connectionString);
            Goods(connectionString);
            Country(connectionString);
            Town(connectionString);
            PeopleFromTown(connectionString, "10001");
            PeopleFromCountry(connectionString, "804");
            SharesFromCountry(connectionString, "710");

        }

        public static void SharesFromCountry(string connectionString, string param)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                var parameters = new { country = param };
                var shares = connection.Query<ShareForBuyer>("SELECT * FROM share_for_buyer WHERE country_id = @country", parameters);

                Console.WriteLine("------------------SHARES FROM COUNTRY------------------");
                foreach (ShareForBuyer share in shares)
                {
                    Console.WriteLine($"{share}");
                }

                Console.WriteLine("\n\n");
            }
        }

        public static void PeopleFromCountry(string connectionString, string param)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                var parameters = new { country = param };
                var buyers = connection.Query<Buyer>("SELECT buyer_id, first_name, last_name FROM buyer WHERE country_id = @country", parameters);

                Console.WriteLine("------------------PEOPLE FROM COUNTRY------------------");
                foreach (Buyer buyer in buyers)
                {
                    Console.WriteLine($"{buyer.buyer_id}\t{buyer.first_name}\t{buyer.last_name}");
                }

                Console.WriteLine("\n\n");
            }
        }

        public static void PeopleFromTown(string connectionString, string param)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                var parameters = new { town = param};
                var buyers = connection.Query<Buyer>("SELECT buyer_id, first_name, last_name FROM buyer WHERE town_id = @town", parameters);

                Console.WriteLine("------------------PEOPLE FROM TOWN------------------");
                foreach (Buyer buyer in buyers)
                {
                    Console.WriteLine($"{buyer.buyer_id}\t{buyer.first_name}\t{buyer.last_name}");
                }

                Console.WriteLine("\n\n");
            }
        }

        public static void Town(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                IEnumerable<string> towns = connection.Query<string>("SELECT town_name FROM town");

                Console.WriteLine("------------------TOWNS------------------");
                foreach (string line in towns)
                {
                    Console.WriteLine(line);
                }
                Console.WriteLine("\n\n");
            }
        }

        public static void Country(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                IEnumerable<string> countrys = connection.Query<string>("SELECT country_name FROM country");

                Console.WriteLine("------------------COUNTRY------------------");
                foreach (string line in countrys)
                {
                    Console.WriteLine(line);
                }
                Console.WriteLine("\n\n");
            }
        }

        public static void Goods(string connectionString)
        {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                IEnumerable<PromotionalProduct> goods = connection.Query<PromotionalProduct>("SELECT * FROM promotional_product");

                Console.WriteLine("------------------GOODS------------------");
                foreach (PromotionalProduct product in goods)
                {
                    Console.WriteLine(product);
                }
                Console.WriteLine("\n\n");
            }
        }

        public static void Section(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                IEnumerable<string> section = connection.Query<string>("SELECT section_name FROM interested_section");

                Console.WriteLine("------------------SECTIONS------------------");
                foreach (string line in section)
                {
                    Console.WriteLine(line);
                }
                Console.WriteLine("\n\n");
            }
        }

        public static void Emails(string connectionString)
        {
            using(SqlConnection connection= new SqlConnection(connectionString))
            {
                IEnumerable<Buyer> emails= connection.Query<Buyer>("SELECT first_name, last_name, email FROM buyer");

                Console.WriteLine("------------------EMAILS------------------");
                foreach (Buyer email in emails)
                {
                    Console.WriteLine($"{email.first_name} {email.last_name} {email.email}");
                }
                Console.WriteLine("\n\n");
            }
        }

        public static void AllBuyers(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {                
                IEnumerable<Buyer> buyers = connection.Query<Buyer>("SELECT * FROM buyer").ToList();

                Console.WriteLine("------------------ALL BUYES------------------");
                foreach (Buyer buyer in buyers)
                {
                    Console.WriteLine(buyer);
                }
                Console.WriteLine("\n\n");
            }
        }

    }
}


