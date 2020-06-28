using System;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace SecurityProjectConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome, Do you already have an account created? Y/N");
            string RegisterOrLogin = Console.ReadLine();
            if (RegisterOrLogin == "Y" || RegisterOrLogin == "y")
            {
                Console.Clear();

            }
            else if (RegisterOrLogin == "N" || RegisterOrLogin == "n")
            {
                Console.Clear();
                Console.WriteLine("REGISTER \n");
                Console.WriteLine("Username:");
                string newUsername = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Invalid Response. Please write either Y or N.");
            }
            //This is a change
        }
    }
}
