using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Databases
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.White;
                Write_To_Database();
                Console.ReadLine();
                Read_From_Database();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR!");
                Console.WriteLine("Source: {0};", ex.Source);
                Console.WriteLine("Message: {0};", ex.Message);
                Console.WriteLine("HelpLink: {0}.", ex.HelpLink);
            }
            finally
            {
                Console.ReadLine();
            }
        }
        static void Write_To_Database()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=HP\HOMESERVER;Initial Catalog=database_001;Integrated Security=True";
            SqlCommand command = new SqlCommand("INSERT INTO People (id,name,date,height) VALUES (5,'name5','2005-01-01 10:10:10.500','205')", conn);
            conn.Open();

            command.ExecuteReader();

            conn.Close();
            conn.Dispose();

            Console.WriteLine("Writing to database was successful");
        }
        static void Read_From_Database()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=HP\HOMESERVER;Initial Catalog=database_001;Integrated Security=True";
            SqlCommand command = new SqlCommand("SELECT * FROM People ORDER BY id", conn);
            conn.Open();

            SqlDataReader reader = command.ExecuteReader();

            conn.Close();
            conn.Dispose();

            Console.WriteLine("Reading from database was successful");
        }
    }
}
