using System;

namespace bookStore
{
    class myStore
    {
        static void Main(string[] args)
        {
            
            book book1 = new book();
            book1.SetTrans(); // Increment transaction count
            book1.SetId(101);
            book1.SetTitle("The Great Gatsby");
            book1.SetAuthor("F. Scott Fitzgerald");

            
            book book2 = new book();
            book2.SetTrans(); // Increment transaction count
            Console.WriteLine("Please enter the book ID: ");
            book2.SetId(int.Parse(Console.ReadLine()));
            Console.WriteLine("Please enter the book title: ");
            book2.SetTitle(Console.ReadLine());
            Console.WriteLine("Please enter the book author: ");
            book2.SetAuthor(Console.ReadLine());

           
            book book3 = new book(102, "To Kill a Mockingbird", "Harper Lee");
            book3.SetTrans(); // Increment transaction count

            
            Console.WriteLine("Please enter the book ID: ");
            int tempID = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the book title: ");
            string tempTitle = Console.ReadLine();
            Console.WriteLine("Please enter the book author: ");
            string tempAuthor = Console.ReadLine();
            book book4 = new book(tempID, tempTitle, tempAuthor);
            book4.SetTrans(); // Increment transaction count

           
            displayBooks(book1);
            displayBooks(book2);
            displayBooks(book3);
            displayBooks(book4);
        }

        
        static void displayBooks(book bk)
        {
            Console.WriteLine("Here's your book information:");
            Console.WriteLine($"Book ID: {bk.GetId()}");
            Console.WriteLine($"Book Title: {bk.GetTitle()}");
            Console.WriteLine($"Book Author: {bk.GetAuthor()}");
            Console.WriteLine($"Number of Transactions: {bk.GetTrans()}"); // Include transaction count
            Console.WriteLine();
        }
    }

    
    class book
    {
        
        private int _Id;
        private string _Title;
        private string _Author;
        private static int _transactions = 0;

       
        public book()
        {
            
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

        public void SetId(int id)
        {
            _Id = id;
        }

        
        public string GetTitle()
        {
            return _Title;
        }

        public void SetTitle(string title)
        {
            _Title = title;
        }

        
        public string GetAuthor()
        {
            return _Author;
        }

        public void SetAuthor(string author)
        {
            _Author = author;
        }

        
        public int GetTrans()
        {
            return _transactions;
        }

        public void SetTrans()
        {
            _transactions++;
        }
    }
}
