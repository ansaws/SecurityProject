using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace SecurityProjectConsole
{
    class Program
    {
        MySqlConnection Myconnection = new MySqlConnection("Server = sql.saye.org; Database=AnnishAndShivansh;Uid=student; Pwd=LearnSQL;SslMode=Required;");
        MySqlCommand cmd;
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
                List<String> data register();/*
                Console.WriteLine("REGISTER \n");
                Console.WriteLine("Username:");
                string newUsername = Console.ReadLine();*/
            }
            else
            {
                Console.WriteLine("Invalid Response. Please write either Y or N.");
            }
            //This is a change
        }

        private List<String> register()
        {
            List<String> userData = new List<String>();
            Console.WriteLine("Username: ");
            userData.Add(Console.ReadLine());
            Console.WriteLine("Password: ");
            userData.Add(Console.ReadLine());
            Console.WriteLine("What is your favorite animal: ");
            userData.Add(Console.ReadLine());
            Console.WriteLine("Phone: ");
            userData.Add(Console.ReadLine());
            return userData;
            
        }
    }
}
