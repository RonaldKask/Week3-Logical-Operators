using System;

namespace Week3LogicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your login and password.");
            string login;
            string password;
            Console.WriteLine("Login: ");
            login = Console.ReadLine();
            Console.WriteLine("Password:");
            password = Console.ReadLine();

            if((login == "admin") && (password == "pass1234"))
            {
                Console.WriteLine("Welcome!");
            } else if((login == "admin") && (password != "pass1234"))
            {
                Console.WriteLine("The passworld is incorrect.");
            } else if((login != "admin") && (password == "pass1234"))
            {
                Console.WriteLine("The login is incorrect.");
            }else if ((login != "admin") && (password != "pass1234"))
            {
                Console.WriteLine("The login and the password are both incorrect.");
            }
        }
    }
}
