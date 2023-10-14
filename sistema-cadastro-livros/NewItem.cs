using System;
using BooksClasses;

namespace sistemacadastrolivros
{
    public partial class NewItem : Gtk.Window
    {
        public NewItem() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
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

            book.Cadastrar();
            this.Destroy();
        }
    }
}
