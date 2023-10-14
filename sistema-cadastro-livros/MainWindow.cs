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
        NewItem item = new NewItem();

        item.Show();
    }

    protected void LoadOrUpdate()
    {
        Database db = new Database();

        books = db.LoadItems();

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
}
