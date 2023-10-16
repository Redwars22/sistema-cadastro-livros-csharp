using System;
using Gtk;
using System.IO;
using Newtonsoft.Json;
using BooksClasses;
using System.Collections.Generic;

namespace sistemacadastrolivros
{
    public class Database
    {
        private List<Book> books = new List<Book>();
        private const string FILE_PATH = "database.json";
         
        public Database()
        {
        }

        private void SaveToFile(string Json, string Path)
        {
            try
            {
                File.WriteAllText(Path, Json);
            }
            catch (Exception e)
            {
                ErrorMessageForm err = new ErrorMessageForm(e.Message);
            }
        }

        public List<Book> Search(List<Book> Books, string Query)
        {
            List <Book> FoundItems = new List<Book>();

            foreach(Book book in Books)
            {
                if(
                    book.Title.ToLower().Trim().Contains(Query.ToLower().Trim()) ||
                    book.Author.ToLower().Trim().Contains(Query.ToLower().Trim()) ||
                    book.ISBN.ToLower().Trim().Equals(Query)
                    )
                {
                    FoundItems.Add(book);
                }
            }

            return FoundItems;
        }

        public void DeleteItem(Book Item) 
        {
            List<Book> AllBooks = this.LoadItems();
            List<Book> FinalList = new List<Book>();

            foreach (Book book in AllBooks) 
            {
                if (!(Item.Equals(book)))
                {
                    FinalList.Add(book);
                }
            }

            string json = JsonConvert.SerializeObject(FinalList);

            this.SaveToFile(json, FILE_PATH);
        }

        public void AddItem(string Title, string ISBN, string Author, string Genre, string Language, int NumberOfPages)
        { 
            Book book = new Book(
                Title,
                ISBN,
                Author,
                Genre,
                Language,
                NumberOfPages
                );

            this.books.Add(book);

            string json = JsonConvert.SerializeObject(this.books);

            string filePath = "database.json"; // Replace with your desired file path

            this.SaveToFile(json, filePath);
        }

        public List<Book> LoadItems()
        {
            string filePath = "database.json"; // Replace with the path to your JSON file

            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                this.books = JsonConvert.DeserializeObject<List<Book>>(json);
            }
            else
            {
                ErrorMessageForm err = new ErrorMessageForm("Não foi possível carregar os dados.\nO arquivo foi deletado ou não há nenhum livro cadastrado.");
            }

            return this.books;
        }

        public void UpdateItem(List<Book> BooksCol, Book Item, string ISBN)
        {
            foreach (Book book in BooksCol)
            {
                if(book.ISBN == ISBN)
                {
                    book.Title = Item.Title;
                    book.Author = Item.Author;
                    book.Genre = Item.Genre;
                    book.Language = Item.Language;
                    book.NumberOfPages = Item.NumberOfPages;
                }
            }

            string json = JsonConvert.SerializeObject(this.books);

            this.SaveToFile(json, FILE_PATH);
        }
    }
}
