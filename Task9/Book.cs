using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;
using Newtonsoft.Json;

namespace Task9
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
            using (XmlWriter writer = XmlWriter.Create(path, new XmlWriterSettings() { Indent = true }))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("Books");
                foreach (Book book in books)
                {
                    writer.WriteStartElement("Book");
                    writer.WriteElementString("NameOfBook", book.NameOfBook);
                    writer.WriteElementString("AuthorOfBook", book.AuthorOfBook);
                    writer.WriteElementString("NumberOfPages", book.NumberOfPages.ToString());
                    writer.WriteElementString("PublishingYear", book.PublishingYear.ToString());
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
                writer.Flush();
            }
        }
        public static List<Book> LoadFromXML(string path)
        {
            List<Book> books = new List<Book>();
            using (XmlReader xmlReader = XmlReader.Create(path, new XmlReaderSettings() { IgnoreWhitespace = true }))
            {
                xmlReader.MoveToContent();
                while (xmlReader.Read())
                {
                    if (xmlReader.NodeType == XmlNodeType.Text)
                    {
                        string nameOfBook = xmlReader.ReadString();
                        xmlReader.Read();
                        string authorOfBook = xmlReader.ReadString();
                        xmlReader.Read();
                        int numberOfPages = Convert.ToInt32(xmlReader.ReadString());
                        xmlReader.Read(); 
                        int publishingYear = Convert.ToInt32(xmlReader.ReadString());
                        books.Add(new Book(nameOfBook, authorOfBook, numberOfPages, publishingYear));
                    }
                }
            }
            return books;
        }
        public static void SaveAsJSON(List<Book> books, string path)
        {
            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                writer.Formatting = Newtonsoft.Json.Formatting.Indented;
                writer.WriteStartObject();
                foreach (Book book in books)
                {
                    writer.WritePropertyName("NameOfBook");
                    writer.WriteValue(book.NameOfBook);
                    writer.WritePropertyName("AuthorOfBook");
                    writer.WriteValue(book.AuthorOfBook);
                    writer.WritePropertyName("NumberOfPages");
                    writer.WriteValue(book.NumberOfPages);
                    writer.WritePropertyName("PublishingYear");
                    writer.WriteValue(book.PublishingYear);
                }
                writer.WriteEndObject();
            }
            File.WriteAllText(path, sb.ToString());
        }

        public static List<Book> LoadFromJSON(string path)
        {
            List<Book> books = new List<Book>();
            string nameOfBook = string.Empty;
            string authorOfBook = string.Empty;
            int numberOfPages = 0;
            int publishingYear = 0;
            using (JsonTextReader reader = new JsonTextReader(new StreamReader(path)))
            {
                while(reader.Read())
                {
                    if (reader.Value != null)
                    {
                        if(reader.Value.ToString() == "NameOfBook")
                        {
                            reader.Read();
                            nameOfBook = reader.Value.ToString();
                        }
                        if (reader.Value.ToString() == "AuthorOfBook")
                        {
                            reader.Read();
                            authorOfBook = reader.Value.ToString();
                        }
                        if (reader.Value.ToString() == "NumberOfPages")
                        {
                            reader.Read();
                            numberOfPages = Convert.ToInt32(reader.Value);
                        }
                        if (reader.Value.ToString() == "PublishingYear")
                        {
                            reader.Read();
                            publishingYear = Convert.ToInt32(reader.Value);
                        }
                        if ((nameOfBook != null) && (authorOfBook != null) && (numberOfPages != 0) && (publishingYear != 0))
                        {
                            books.Add(new Book(nameOfBook, authorOfBook, numberOfPages, publishingYear));
                            nameOfBook = string.Empty;
                            authorOfBook = string.Empty;
                            numberOfPages = 0;
                            publishingYear = 0;
                        }
                    }
                }
            }
            return books;
        }
    }
}
