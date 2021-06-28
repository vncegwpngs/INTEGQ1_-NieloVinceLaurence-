using BManagement.DL;
using System;
using System.Collections.Generic;

namespace BManagement.BL
{
    public class UserValidation
    {
        public List<User> UserCredentials = new List<User>()
        {
            new User("Vince","zxcvince")
        };

        public void LogIn()
        {

            bool successful = false;
            Console.WriteLine("Enter username:");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter Password:");
            string passWord = Console.ReadLine();

            foreach (User user in UserCredentials)
            {
                if (userName == user.UserName && passWord == user.PassWord)
                {
                    Console.WriteLine("Log in Success");
                    successful = true;

                }
            }
            if (!successful)
            {
                Console.WriteLine("Wait for it to exit...");
            }
        }
        public void Register()
        {
            Console.WriteLine("Enter username: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter password: ");
            string passWord = Console.ReadLine();

            UserCredentials.Add(new User(userName, passWord));
            Console.WriteLine("Registered Successfully!");

            foreach (User user in UserCredentials)
            {
                Console.WriteLine("Username:{0}, Passw:{1}", user.UserName, user.PassWord);
            }

        }
    }
}