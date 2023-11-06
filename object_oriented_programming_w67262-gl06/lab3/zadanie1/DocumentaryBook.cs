using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_oriented_programming_w67262_gl06.lab3.zadanie1
{
    internal class DocumentaryBook : Book
    {
        private string mainCharacter;

        public DocumentaryBook(string title, Person author, DateTime dateTimeStr, string mainCharacter) : base(title, author, dateTimeStr)
        {
            this.mainCharacter = mainCharacter;
        }
    }
}
