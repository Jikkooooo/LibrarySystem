using MySql.Data.MySqlClient;
using System;

namespace LibrarySystem
{
    public static class DatabaseHelper
    {
        // Create a method to get a new connection each time it's needed
        public static MySqlConnection GetConnection()
        {
            string connectionString = "Server=localhost;Database=librarydb;User=root;Password=;";

            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                Console.WriteLine("Database connection established.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error connecting to the database: " + ex.Message);
            }
            return connection;
        }

        // Check if the connection is active
        public static bool IsConnected(MySqlConnection connection)
        {
            return connection != null && connection.State == System.Data.ConnectionState.Open;
        }
    }
}
