using System;
namespace BooksClasses
{
    public class Book
    {
        public string Title;
        public string ISBN;
        public string Author;
        public string Genre;
        public string Language;
        public int NumberOfPages;

        public Book(string Title, string ISBN, string Author, string Genre, string Language, int NumberOfPages)
        {
            this.Title = Title;
            this.ISBN = ISBN;
            this.Author = Author;
            this.Genre = Genre;
            this.Language = Language;
            this.NumberOfPages = NumberOfPages;
        }

        public string ToString() {
            return $"{this.Title} ({this.ISBN}) - {this.Author} - {this.Genre}. {this.Language}. {this.NumberOfPages}pgs.";
        }
    }
}
