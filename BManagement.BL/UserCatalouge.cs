using System;

namespace BManagement.BL
{
    public class UserCatalogue
    {
        public void Catalogue()
        {
            ManageBooks bookServices = new ManageBooks();

        START:
            Console.WriteLine("(1) Book View");
            Console.WriteLine("(2) Book Add");
            Console.WriteLine("(3) Book Removed");
            Console.WriteLine("(4) exit           ");
            int userInput = int.Parse(Console.ReadLine());
            switch (userInput)
            {
                case 1:
                    bookServices.BookView();
                    goto START;
                case 2:
                    bookServices.BookAdd();
                    goto START;
                case 3:
                    bookServices.BookRemoved();
                    goto START;

                default:
                    break;
            }

        }
    }
}