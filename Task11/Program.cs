using System;
using System.Collections.Generic;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>
            {
                new Book("The Hobbit, or There and Back Again", "Tolkien", 310, 1937),
                new Book("Jurassic Park", "Crichton", 400, 1990),
                new Book("Harry Potter and the Prisoner of Azkaban", "Rowling", 462, 1999)
            };

            foreach (Book book in books)
                book.OutputInformation();
            Book.SaveAsXML(books, "Books.xml");
            Book.SaveAsJSON(books, "Books.json");

            Console.WriteLine("\nXML file:");
            List<Book> booksFromXMLFile = new List<Book>();
            booksFromXMLFile = Book.LoadFromXML("Books.xml");
            foreach (Book book in booksFromXMLFile)
                book.OutputInformation();

            Console.WriteLine("\nJSON file:");
            List<Book> booksFromJSONFile = new List<Book>();
            booksFromJSONFile = Book.LoadFromJSON("Books.json");
            foreach (Book book in booksFromJSONFile)
                book.OutputInformation();

            Console.ReadLine();
        }
    }
}
