using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_oriented_programming_w67262_gl06.lab3.zadanie1
{
    internal class Reader : Person
    {
        private List<Book> books = new List<Book>();

        public Reader(string FirstName, string LastName, int age, List<Book> books) : base(FirstName, LastName, age)
        {
            this.books = books;
        }

        public void ViewBook()
        {
            foreach (Book book in books)
            {
                Console.WriteLine($"Book = {book.Title} - {book.DateTimeStr} - {book.Author.FirstName} {book.Author.LastName}");
            }
        }

        public void View()
        {
            Console.WriteLine($"Reader: {FirstName} {LastName} {Age}");
            ViewBook();
        }

        public List<Book> Books { get { return books; } }
    }
}
