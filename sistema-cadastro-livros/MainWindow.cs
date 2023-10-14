using System;
using Gtk;
using BooksClasses;
using System.Collections.Generic;
using sistemacadastrolivros;

public partial class MainWindow : Gtk.Window
{ 

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();


        TextBuffer textBuffer = new TextBuffer(new TextTagTable());
        textview2.Buffer = textBuffer;

        Book book1 = new Book(
        "Livro Teste",
        "111111111",
        "Teste Teste",
        "Romance",
        "pt-br",
        999
            );

        //Books.Add(book1);

        //textBuffer.Insert(textBuffer.EndIter, books[0].ToString());
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
}
