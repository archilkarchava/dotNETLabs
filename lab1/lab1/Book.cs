using System;
using System.Collections.Generic;
using System.Text;

namespace lab1
{
    public class Book
    {
        // Auto-implemented readonly property:
        public string Title { get; }
        public string Author { get; }
        public string Genre { get; }
        public string OriginalLanguage { get; }
        public int Pages { get; }
        public DateTime PublicationDate { get; }
        // public Book()
        // {
        //     Title = "unknown";
        // }

        // Constructor that takes one argument:
        public Book(string title, string author, string genre, string original_language, int pages, DateTime publication_date)
        {
            Title = title;
            Author = author;
            OriginalLanguage = original_language;
            Pages = pages;
            PublicationDate = publication_date;
        }

        // Method that overrides the base class (System.Object) implementation.
        public override string ToString()
        {
            return string.Format("Title: {0}\nAuthor: {1}\nPublished: {2}\nLanguage: {3}", Title, Author, PublicationDate.Year, OriginalLanguage);
        }
    }
}
