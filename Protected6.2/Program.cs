using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protected6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library(5);
            library.books[0] = new Book("J.K. Rowling", "Harry Potter", 2035, 1997, 522, "Fantasy");
            library.books[1] = new Book("H. Melville", "Moby-Dick", 1042, 1851, 746, "Novel");
            library.books[2] = new Book("M. Cervantes", "Don Quixote", 4234, 1605, 1023, "Novel");
            library.books[3] = new Book("Leo Tostoy", "Anna Karenina", 9431, 1898, 1402, "Tragedy");
            library.books[4] = new Book("Jane Austen", "Pride and Prejudice", 1234, 1930, 416, "Novel");

            library.CompareTwoBooks();
            library.SearchByCode();

            Console.ReadLine();
        }
    }
}
