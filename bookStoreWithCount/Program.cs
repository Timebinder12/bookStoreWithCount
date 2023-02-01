using System;
using System.ComponentModel;

namespace bookStore
{
    class book
    {
        private int _Id;
        private string _Title;
        private string _Author;
        private static int _transactions = 0;
        public book()
        {
            _Id = 0;
            _Title = "";
            _Author = "";
        }

        public book(int id, string title, string author)
        {
            _Id = id;
            _Title = title;
            _Author = author;
        }

        public int GetId()
        {
            return _Id;
        }
        public string GetTitle()
        {
            return _Title;
        }
        public string GetAuthor()
        {
            return _Author;
        }
        public void SetTitle(string title)
        {
            _Title = title;
        }
        public void SetAuthor(string author)
        {
            _Author = author;
        }
        public void SetId(int id)
        {
            _Id = id;
        }
        public void SetTrans()
        {
            _transactions++;
        }
        public int GetTrans()
        {
            return _transactions;
        }
    }
    class myStore
    {
        static void Main(string[] args)
        {
            book book1 = new book();
            book1.SetTrans();
            book1.SetId(1);
            book1.SetAuthor("SpongeBob");
            book1.SetTitle("Who lives in a pineapple under the sea?");

            book book2 = new book();
            book2.SetTrans();
            Console.WriteLine("Please enter the ID of the book.");
            book2.SetId(int.Parse(Console.ReadLine()));
            Console.WriteLine("Please enter the author of the book.");
            book2.SetAuthor(Console.ReadLine());
            Console.WriteLine("Pleae enter the title of the book.");
            book2.SetTitle(Console.ReadLine());

            book book3 = new book(3, "Tales of a ghost", "Danny Phantom");
            book3.SetTrans();

            Console.WriteLine("Please enter the ID of the book.");
            int tempId = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the author of the book.");
            string tempAuthor = Console.ReadLine();
            Console.WriteLine("Please enter the title of the book.");
            string tempTitle = Console.ReadLine();
            book book4 = new book(tempId, tempTitle, tempAuthor);
            book4.SetTrans();

            Console.WriteLine($"This bookstore has: {book1.GetTrans()} books.");
            displayBooks(book1);
            displayBooks(book2);
            displayBooks(book3);
            displayBooks(book4);
        }
        static void displayBooks(book book)
        {
            Console.WriteLine("Here's your book information");
            Console.WriteLine($"Book ID: {book.GetId()}");
            Console.WriteLine($"Book author: {book.GetAuthor()}");
            Console.WriteLine($"Book title: {book.GetTitle()}");
        }


    }
}