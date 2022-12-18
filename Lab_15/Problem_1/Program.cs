using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace Problem_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=WINDOWS-8NR2C06\\SQLEXPRESS;Database=OOP_15_DB;Trusted_Connection=true;Encrypt=false";

            using (SqlConnection AllInfoConnection = new SqlConnection(connectionString))
            {
                AllInfoConnection.Open();
                Console.WriteLine("--------------------------------------------------------OPEN--------------------------------------------------------");

                SqlCommand command = new SqlCommand("SELECT * FROM students_mark", AllInfoConnection);
                SqlDataReader reader= command.ExecuteReader();

                if (reader.HasRows)
                {
                    string columnName1 = reader.GetName(0);
                    string columnName2 = reader.GetName(1);
                    string columnName3 = reader.GetName(2);
                    string columnName4 = reader.GetName(3);
                    string columnName5 = reader.GetName(4);
                    string columnName6 = reader.GetName(5);

                    Console.WriteLine($"{columnName1}\t{columnName2}\t{columnName3}\t{columnName4}\t{columnName5}\t{columnName6}");

                    while (reader.Read())
                    {
                        string first_name = reader.GetString("first_name");
                        string last_name = reader.GetString("last_name");
                        string group_name = reader.GetString("group_name");
                        decimal average_mark = reader.GetDecimal("average_mark");
                        string subject_min_aver_score = reader.GetString("subject_min_aver_score");
                        string subject_max_aver_score = reader.GetString("subject_max_aver_score");

                        Console.WriteLine($"{first_name}\t\t{last_name}\t\t{group_name}\t\t{average_mark}\t\t{subject_min_aver_score}\t\t\t{subject_max_aver_score}");
                    }
                }
                reader.Close();
            }
            Console.WriteLine("--------------------------------------------------------CLOSE--------------------------------------------------------\n\n");


            using (SqlConnection NameStuudentConnection = new SqlConnection(connectionString))
            {
                NameStuudentConnection.Open();
                Console.WriteLine("--------------------------------------------------------OPEN--------------------------------------------------------");

                SqlCommand command = new SqlCommand("SELECT first_name, last_name FROM students_mark", NameStuudentConnection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    string columnName1 = reader.GetName(0);
                    string columnName2 = reader.GetName(1);

                    Console.WriteLine($"{columnName1}\t{columnName2}");

                    while (reader.Read())
                    {
                        string first_name = reader.GetString("first_name");
                        string last_name = reader.GetString("last_name");
                        Console.WriteLine($"{first_name} \t\t{last_name}");
                    }
                }
                reader.Close();
            }
            Console.WriteLine("--------------------------------------------------------CLOSE--------------------------------------------------------\n\n");


            using (SqlConnection AverageMarkConnection = new SqlConnection(connectionString))
            {
                AverageMarkConnection.Open();
                Console.WriteLine("--------------------------------------------------------OPEN--------------------------------------------------------");

                SqlCommand command = new SqlCommand("SELECT average_mark FROM students_mark", AverageMarkConnection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    string columnName1 = reader.GetName(0);

                    Console.WriteLine($"{columnName1}");

                    while (reader.Read())
                    {
                        decimal average_mark = reader.GetDecimal("average_mark");
                        Console.WriteLine($"{average_mark}");
                    }
                }
                reader.Close();
            }
            Console.WriteLine("--------------------------------------------------------CLOSE--------------------------------------------------------\n\n");


            Console.Write("Enter mark: ");
            decimal mark = Convert.ToDecimal(Console.ReadLine());
            using (SqlConnection AverageMarkMoreMarkConnection = new SqlConnection(connectionString))
            {
                AverageMarkMoreMarkConnection.Open();
                Console.WriteLine("--------------------------------------------------------OPEN--------------------------------------------------------");

                SqlCommand command = new SqlCommand("SELECT first_name, last_name, average_mark FROM students_mark WHERE average_mark > @mark", AverageMarkMoreMarkConnection);

                SqlParameter markParam = new SqlParameter("@mark", mark);
                command.Parameters.Add(markParam);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    string columnName1 = reader.GetName(0);
                    string columnName2 = reader.GetName(1);
                    string columnName3 = reader.GetName(2);

                    Console.WriteLine($"{columnName1}\t{columnName2}\t{columnName3}");

                    while (reader.Read())
                    {
                        string first_name = reader.GetString("first_name");
                        string last_name = reader.GetString("last_name");
                        decimal average_mark = reader.GetDecimal("average_mark");

                        Console.WriteLine($"{first_name}\t\t{last_name}\t\t{average_mark}");
                    }
                }
                reader.Close();
            }
            Console.WriteLine("--------------------------------------------------------CLOSE--------------------------------------------------------\n\n");


            using(SqlConnection SubjectMinConnection = new SqlConnection(connectionString))
            {
                SubjectMinConnection.Open();
                Console.WriteLine("--------------------------------------------------------OPEN--------------------------------------------------------");

                SqlCommand command = new SqlCommand("SELECT DISTINCT subject_min_aver_score FROM students_mark", SubjectMinConnection);

                SqlDataReader reader= command.ExecuteReader();
                if(reader.HasRows) 
                {
                    Console.WriteLine(reader.GetName(0));

                    while(reader.Read()) 
                    {
                        Console.WriteLine(reader.GetString("subject_min_aver_score"));
                    }
                }
                reader.Close();
            }
            Console.WriteLine("--------------------------------------------------------CLOSE--------------------------------------------------------\n\n");


            using (SqlConnection Connection2 = new SqlConnection(connectionString))
            {
                Connection2.Open();
                Console.WriteLine("--------------------------------------------------------OPEN--------------------------------------------------------");


                SqlCommand command = new SqlCommand("SELECT MIN(average_mark) FROM students_mark", Connection2);
                decimal MinAverageMark = (decimal)command.ExecuteScalar();

                command.CommandText = "SELECT MAX(average_mark) FROM students_mark";
                decimal MaxAverageMark = (decimal)command.ExecuteScalar();

                command.CommandText = "SELECT COUNT(subject_min_aver_score) FROM students_mark WHERE subject_min_aver_score = 'TI'";
                int countMinMarkTI = (int)command.ExecuteScalar();

                command.CommandText = "SELECT COUNT(subject_max_aver_score) FROM students_mark WHERE subject_max_aver_score = 'TI'";
                int countMaxMarkTI = (int)command.ExecuteScalar();

                Console.WriteLine($"MinAverageMark = {MinAverageMark}\nmaxAverageMark = {MaxAverageMark}\ncountMinMarkTI = {countMinMarkTI}" +
                    $"\ncountMaxMarkTI = {countMaxMarkTI}");


                command.CommandText = "SELECT group_name, COUNT(last_name) AS count_student FROM students_mark GROUP BY group_name";
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    Console.WriteLine($"{reader.GetName(0)}\t{reader.GetName(1)}");

                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader.GetString("group_name")}\t\t{reader.GetInt32("count_student")}");
                    }
                }
                reader.Close();
            }
        }
    }
}
