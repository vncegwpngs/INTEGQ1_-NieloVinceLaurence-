using BManagement.DL;
using System;
using System.Collections.Generic;
namespace BManagement.BL

{
    public class ManageBooks
    {
        public List<Book> BookInfo = new List<Book>()
        {
            new Book ("English","Vince", new DateTime(2019,09,17)),
        };

        public void BookView()
        {
            foreach (Book book in BookInfo)
            {
                Console.WriteLine("Book Name:{0}|Borrower Name: {1}|Date Borrowed:: {2}", book.BookName, book.BorrowerName, book.BorrowedDate);
            }
        }
        public void BookAdd()
            {
                foreach (Book book in BookInfo)
                {
                    Console.WriteLine("Book Name:{0}|Borrower Name: {1}|Date Borrowed:: {2}", book.BookName, book.BorrowerName, book.BorrowedDate);
                }

                Console.WriteLine("Enter Book Name: ");
                string addBookName = Console.ReadLine();

                Console.WriteLine("Enter Borrower's Name: ");
                string addBorrowerName = Console.ReadLine();

                DateTime addBorrowedDate = DateTime.Now;


                BookInfo.Add(new Book(addBookName, addBorrowerName, addBorrowedDate));
                Console.WriteLine("Book Name:{0}|Borrower Name: {1}|Date Borrowed:: {2}", book.BookName, book.BorrowerName, book.BorrowedDate);
                foreach (Book book in BookInfo)
                {
                    Console.WriteLine("Book Name:{0}|Borrower Name: {1}|Date Borrowed:: {2}", book.BookName, book.BorrowerName, book.BorrowedDate);
                }
            }
        public void BookRemoved()
            {
                Console.WriteLine("Enter The Index Position:");
                int indexPosition = int.Parse(Console.ReadLine());

                BookInfo.RemoveAt(indexPosition);
               
                foreach (Book book in BookInfo)
                {
                    Console.WriteLine("Book Name:{0}|Borrower Name: {1}|Date Borrowed:: {2}", book.BookName, book.BorrowerName, book.BorrowedDate);
                }
            }
        }
    }