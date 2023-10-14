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

        public Database()
        {
        }

        public void UpdateItem() { }

        public void DeleteItem() { }

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

            try
            {
                File.WriteAllText(filePath, json);
            } catch(Exception e)
            {
                ErrorMessageForm err = new ErrorMessageForm(e.Message);
            }
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
    }
}
