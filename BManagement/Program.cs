using BManagement.BL;
using System;

namespace BManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            UserValidation user = new UserValidation();

            Console.WriteLine("=======================");
            Console.WriteLine("==  BOOK MANAGEMENT  ==");
            Console.WriteLine("=======================");
            Console.WriteLine("\n(1)Log-in ");
            Console.WriteLine("\n(2)Register");
            Console.WriteLine("\nPlease Select:");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput.Equals(1))
            {
                user.LogIn();
            }
            else if (userInput.Equals(2))
            {
                user.Register();
            }
            else
            {

            }



        }

    }
}