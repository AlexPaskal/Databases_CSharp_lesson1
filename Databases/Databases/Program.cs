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
            
        }
        static void Read_From_Database()
        {
            
        }
    }
}
