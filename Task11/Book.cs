using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Task11
{
    [Serializable]
    public class Book
    {
        public string NameOfBook { set; get; }
        public string AuthorOfBook { set; get; }
        public int NumberOfPages { set; get; }
        public int PublishingYear { set; get; }

        public Book()
        {
            NameOfBook = string.Empty;
            AuthorOfBook = string.Empty;
            NumberOfPages = 0;
            PublishingYear = 0;
        }

        public Book(string nameOfBook, string authorOfBook, int numberOfPages, int publishingYear)
        {
            NameOfBook = nameOfBook;
            AuthorOfBook = authorOfBook;
            NumberOfPages = numberOfPages;
            PublishingYear = publishingYear;
        }
        public void OutputInformation()
        {
            Console.WriteLine($"{NameOfBook} --- {AuthorOfBook} --- {NumberOfPages} --- {PublishingYear}");
        }
        public static void SaveAsXML(List<Book> books, string path)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Book>));
            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                xmlSerializer.Serialize(streamWriter, books);
            }
        }
        public static List<Book> LoadFromXML(string path)
        {
            List<Book> books = new List<Book>();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Book>));
            using (StreamReader streamReader = new StreamReader(path))
            {
                books = (List<Book>)xmlSerializer.Deserialize(streamReader);
            }
            return books;
        }
        public static void SaveAsJSON(List<Book> books, string path)
        {
            JsonSerializer jsonSerializer = new JsonSerializer();
            using (JsonWriter jsonWriter = new JsonTextWriter(new StreamWriter(path)))
            {
                jsonSerializer.Serialize(jsonWriter, books);
            }
        }
        public static List<Book> LoadFromJSON(string path)
        {
            List<Book> books = new List<Book>();
            books = JsonConvert.DeserializeObject<List<Book>>(File.ReadAllText(path));
            return books;
        }
    }
}
