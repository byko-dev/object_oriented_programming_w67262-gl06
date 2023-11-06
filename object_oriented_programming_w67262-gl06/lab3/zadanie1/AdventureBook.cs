using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_oriented_programming_w67262_gl06.lab3.zadanie1
{
    internal class AdventureBook : Book
    {
        private string description;

        public AdventureBook(string title, Person author, DateTime dateTimeStr, string description) : base(title, author, dateTimeStr)
        {
            this.description = description;
        }
    }
}
