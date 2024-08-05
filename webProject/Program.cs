using System;
using System.Data.SqlClient;

namespace AdoNetProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Nepal";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM YourTable";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine($"{reader[0]} {reader[1]}");
                }
            }
        }
    }
}
