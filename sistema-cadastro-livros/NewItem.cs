using System;
using BooksClasses;
using System.Collections.Generic;

namespace sistemacadastrolivros
{
    public partial class NewItem : Gtk.Window
    {
        private string Mode = "create";
        private string ISBN = "";

        public NewItem(string Mode) :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();

            this.Mode = Mode;

            if(this.Mode == "edit")
            {
                NewBook.Label = "Salvar Alterações";
            }
            else
            {
                SearchByISBN.Sensitive = false;
                DeleteButton.Sensitive = false;
            }
        }

        protected void OnButton2Clicked(object sender, EventArgs e)
        {
            string name = TitleInput.Text;
            string author = AuthorInput.Text;

            if(TitleInput.Text == "")
            {
                ErrorMessageForm err = new ErrorMessageForm("O título do livro é obrigatório");
                return;
            }

            Book book = new Book(
                TitleInput.Text,
                ISBNInput.Text,
                AuthorInput.Text,
                GenreInput.Text,
                LanguageInput.Text,
                PageCount.ValueAsInt
                );

            if(this.Mode == "create")
                book.Cadastrar();
            else
            {
                Database db = new Database();
                List<Book> books = db.LoadItems();

                try
                {
                    db.UpdateItem(books, book, this.ISBN);
                } catch(Exception exc)
                {
                    ErrorMessageForm err = new ErrorMessageForm(exc.Message);
                }
            }
            this.Destroy();
        }

        protected void OnSearchByISBNClicked(object sender, EventArgs e)
        {
            string ISBNCode = ISBNInput.Text;

            Database db = new Database();

            List<Book> books = db.LoadItems();
            List<Book> foundItem = db.Search(books, ISBNCode.Trim());

            if (foundItem.Count >= 1)
            {
                TitleInput.Text = foundItem[0].Title;
                AuthorInput.Text = foundItem[0].Author;
                GenreInput.Text = foundItem[0].Genre;
                ISBNInput.Text = foundItem[0].ISBN;
                LanguageInput.Text = foundItem[0].Language;
                PageCount.Value = foundItem[0].NumberOfPages;

                this.ISBN = foundItem[0].ISBN;
            }
            else
            {
                ErrorMessageForm err = new ErrorMessageForm("Nenhum livro cadastrado com esse ISBN");
            }
        }

        protected void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            if(this.ISBN != "") {
                Database db = new Database();

                List<Book> books = db.LoadItems();
                List<Book> foundItem = db.Search(books, this.ISBN);

                if(foundItem.Count >= 1)
                    db.DeleteItem(foundItem[0]);
            }
            else
            {
                ErrorMessageForm err = new ErrorMessageForm("Não é possível deletar o livro.\nEncontre-o pelo seu ISBN primeiro.");
            }
        }
    }
}
