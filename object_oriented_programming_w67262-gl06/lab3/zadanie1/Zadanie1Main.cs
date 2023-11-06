using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_oriented_programming_w67262_gl06.lab3.zadanie1
{
    internal class Zadanie1Main
    {
        public Zadanie1Main()
        {
            Person author = new Person("Major", "Suchodolski", 57);

            Book book = new Book("Nierzadnica", author, DateTime.Now);
            Book book1 = new Book("Szkolna 17 - Major i Los", author, DateTime.Now);
            Book book2 = new Book("Pustynia czy Puszcza", author, DateTime.Now);
            Book book3 = new Book("To wszystko to fikcja jest", author, DateTime.Now);

            Reader reader = new Reader("Krzysztof", "Kononowicz", 66, new List<Book> { book, book1, book3 });
            Reader reader1 = new Reader("Mexicano", "Szczynpijec", 55, new List<Book> { book3, book });
            Reader reader2 = new Reader("Mariusz", "Organista", 20, new List<Book> { book, book1, book3, book2 });

            reader.View();
            reader.ViewBook();

            reader.View();
            reader1.ViewBook();

            reader.View();
            reader2.ViewBook();

            Reviewer reviewer = new Reviewer("Andrzej", "Ruzmus", 44, new List<Book> { book3, book2 });
            Reviewer reviewer1 = new Reviewer("Marek", "Towarek", 44, new List<Book> { book, book1 });

            reviewer.Review();
            reviewer1.Review();

            List<Person> personList = new List<Person>();
            personList.Add(author);
            personList.Add(reader);
            personList.Add(reader1);
            personList.Add(reader2);
            personList.Add(reviewer1);
            personList.Add(reviewer);


            foreach (Person personObj in personList)
            {
                personObj.View();
            }
        }

    }
}
