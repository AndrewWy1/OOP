using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Net.Http.Headers;
using System.Reflection.PortableExecutable;
using System.Text.Unicode;


namespace Problem_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string connectionString = "Server=WINDOWS-8NR2C06\\SQLEXPRESS;Database=stationery;Trusted_Connection=true;Encrypt=false";

            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                Console.WriteLine("--------------------------------------------------------OPEN--------------------------------------------------------");

                SqlCommand command= new SqlCommand("SELECT * FROM stationery_goods", connection);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    Console.WriteLine($"{reader.GetName(0)} \t{reader.GetName(1)} \t{reader.GetName(2)} \t{reader.GetName(3)}");

                    while(reader.Read())
                    {
                        Console.WriteLine($"{reader.GetInt16("stationery_id")}\t\t{reader.GetString("stationery_name")}\t\t{reader.GetString("stationery_type")}\t\t\t{reader.GetDecimal("cost")}");
                    }
                }
                reader.Close();
            }
            Console.WriteLine("--------------------------------------------------------CLOSE--------------------------------------------------------\n\n");


            using (SqlConnection connection1 = new SqlConnection(connectionString))
            {
                connection1.Open();
                Console.WriteLine("--------------------------------------------------------OPEN--------------------------------------------------------");

                SqlCommand command = new SqlCommand("SELECT stationery_type FROM stationery_goods", connection1);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    Console.WriteLine($"{reader.GetName(0)}");

                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader.GetString("stationery_type")}");
                    }
                }
                reader.Close();
            }
            Console.WriteLine("--------------------------------------------------------CLOSE--------------------------------------------------------\n\n");


            using (SqlConnection connection2 = new SqlConnection(connectionString))
            {
                connection2.Open();
                Console.WriteLine("--------------------------------------------------------OPEN--------------------------------------------------------");

                SqlCommand command = new SqlCommand("SELECT * FROM manager", connection2);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    Console.WriteLine($"{reader.GetName(0)}\t{reader.GetName(1)}\t{reader.GetName(2)}");

                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader.GetInt16("manager_id")}\t\t{reader.GetString("first_name")}\t\t{reader.GetString("last_name")}");
                    }
                }
                reader.Close();
            }
            Console.WriteLine("--------------------------------------------------------CLOSE--------------------------------------------------------\n\n");
        

            using(SqlConnection connection3 = new SqlConnection(connectionString))
            {
                connection3.Open();
                Console.WriteLine("--------------------------------------------------------OPEN--------------------------------------------------------");

                SqlCommand command = new SqlCommand("SELECT MAX(count_stationery_type) FROM stationery_type", connection3);
                int maxCount = (int)command.ExecuteScalar();

                command.CommandText = "SELECT MIN(count_stationery_type) FROM stationery_type";
                int minCount = (int)command.ExecuteScalar();

                command.CommandText = "SELECT MIN(cost) FROM stationery_goods";
                decimal minCost = (decimal)command.ExecuteScalar();

                command.CommandText = "SELECT MAX(cost) FROM stationery_goods";
                decimal maxCost = (decimal)command.ExecuteScalar();


                Console.WriteLine($"maxCount = {maxCount}\nminCount = {minCount}\nminCost = {minCost}\nmaxCost = {maxCost}");
            }
            Console.WriteLine("--------------------------------------------------------CLOSE--------------------------------------------------------\n\n");


        }
    }
}
