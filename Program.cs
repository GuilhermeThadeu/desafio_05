using Npgsql;
using System;
using System.Data.SqlClient;
using Xceed.Wpf.Toolkit;

namespace Desafio_05
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string connectionString;
                NpgsqlConnection connection;

                connectionString = "Host=localhost;Username=postgres;Password=9630;Database=postgres";
                connection = new NpgsqlConnection(connectionString);
                connection.Open();
                Console.WriteLine("Se conectou ao banco de dados!");
                connection.Close();
            }
            catch (NpgsqlException)
            {
                Console.WriteLine("Erro ao se conectar");
                
            }

        }


    }
}