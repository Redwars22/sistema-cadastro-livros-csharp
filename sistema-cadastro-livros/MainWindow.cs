using System;
using Gtk;
using BooksClasses;
using System.Collections.Generic;
using sistemacadastrolivros;

public partial class MainWindow : Gtk.Window
{
    private List<Book> books = new List<Book>();
    TextBuffer textBuffer = new TextBuffer(new TextTagTable());

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
        textview2.Buffer = textBuffer;
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnButton2Clicked(object sender, EventArgs e)
    {
        NewItem item = new NewItem("create");

        item.Show();
    }

    protected void LoadOrUpdate()
    {
        Database db = new Database();

        books = db.LoadItems();

        textBuffer.Clear();

        foreach (Book book in this.books)
        {
            Book bookToStr = new Book(
                book.Title,
                book.ISBN,
                book.Author,
                book.Genre,
                book.Language,
                book.NumberOfPages
                );

            textBuffer.Insert(textBuffer.EndIter, bookToStr.ToString() + "\n");
        }
    }

    protected void OnLoadClicked(object sender, EventArgs e)
    {
        this.LoadOrUpdate();
    }

    protected void OnButton4Clicked(object sender, EventArgs e)
    {
        this.LoadOrUpdate();
    }

    protected void OnButton7Clicked(object sender, EventArgs e)
    {
        Database db = new Database();

        string query = SearchField.Text;

        List<Book> data = db.Search(this.books, query);

        textBuffer.Clear();

        foreach (Book book in data) {
            textBuffer.Insert(textBuffer.EndIter, book.ToString() + "\n");
        }
    }

    protected void OnButton3Clicked(object sender, EventArgs e)
    {
        NewItem editForm = new NewItem("edit");
    }

    protected void OnButton1Clicked(object sender, EventArgs e)
    {
        ErrorMessageForm err = new ErrorMessageForm(
            "Sistema de Cadastro de Livros em C# com JSON\nMais um projeto do AndrewNation\nGitHub: https://github.com/Redwars22"
            );

        err.Show();
        err.Title = "Sobre o App";
    }
}
