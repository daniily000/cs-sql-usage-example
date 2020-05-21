using System;
using System.Data.SqlClient;
using System.IO;

/** Workfolder should be defined where this src is */
namespace ConsoleApp1
{

    class Program
    {
        
        public const string connectionString = "Data Source=*****;User ID=*****;Password=*****";
        public const string sqlPath = "net\\sql\\DbInitializeScript.sql";

        static void Main(string[] args)
        {
            Console.WriteLine("Hey, this is the demo which creates a database on some SQL Server");
            try {
                CreateDatabase();
                Console.WriteLine("Database created successfully");
            } catch (Exception e) {
                Console.WriteLine("Failed to create database");
                Console.WriteLine(e);
            }
        }

        private static string ReadSqlInstructions() {
            return File.ReadAllText(sqlPath);
        }

        private static void CreateDatabase()
        {
            string queryString = ReadSqlInstructions();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
