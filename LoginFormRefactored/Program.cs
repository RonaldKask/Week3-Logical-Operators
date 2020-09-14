using System;

namespace LoginFormRefactored
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your login and password.");
            string login, password;
            Console.WriteLine("Login: ");
            login = Console.ReadLine();
            Console.WriteLine("Password:");
            password = Console.ReadLine();

            if(login == "admin" && password == "pass1234")
            {
                Console.WriteLine("Welcome, Admin!");
            }else
            {
                Console.WriteLine("Login failed. Please try again");
            }
        }
    }
}
