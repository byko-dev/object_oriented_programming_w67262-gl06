using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_oriented_programming_w67262_gl06.lab3.zadanie1
{
    internal class Reviewer : Reader
    {
        public Reviewer(string FirstName, string LastName, int age, List<Book> books) : base(FirstName, LastName, age, books) {}

        public void Review()
        {
            View();

            Random rng = new Random();

            foreach (Book book in Books)
            {
                int rate = rng.Next(0, 5);
                Console.WriteLine($"Book = {book.Title} - {book.DateTimeStr} - {book.Author.FirstName} {book.Author.LastName} - rate: {rate} ");
            }
        }
    }
}
