using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_oriented_programming_w67262_gl06.lab3.zadanie1
{
    internal class Book
    {
        private string title;
        private Person author;
        private DateTime dateTimeStr;

        public Book(string title, Person author, DateTime dateTimeStr)
        {
            this.title = title;
            this.author = author;
            this.dateTimeStr = dateTimeStr;
        }

        public void View() {}

        public string Title
        {
            get { return title; }
            set { title = Title; }
        }

        public DateTime DateTimeStr
        {
            get { return dateTimeStr; }
            set { dateTimeStr = DateTimeStr; }
        }

        public Person Author
        {
            get { return author; }
            set { author = Author; }
        }

    }
}
