
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.Fixed fixed1;

	private global::Gtk.Button load;

	private global::Gtk.Button button2;

	private global::Gtk.Button button3;

	private global::Gtk.Button button4;

	private global::Gtk.ScrolledWindow GtkScrolledWindow;

	private global::Gtk.TextView textview2;

	private global::Gtk.Button button1;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(1));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.fixed1 = new global::Gtk.Fixed();
		this.fixed1.Name = "fixed1";
		this.fixed1.HasWindow = false;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.load = new global::Gtk.Button();
		this.load.CanFocus = true;
		this.load.Name = "load";
		this.load.UseUnderline = true;
		this.load.Label = global::Mono.Unix.Catalog.GetString("Carregar");
		global::Gtk.Image w1 = new global::Gtk.Image();
		w1.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-directory", global::Gtk.IconSize.Menu);
		this.load.Image = w1;
		this.fixed1.Add(this.load);
		global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.load]));
		w2.X = 5;
		w2.Y = 5;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.button2 = new global::Gtk.Button();
		this.button2.CanFocus = true;
		this.button2.Name = "button2";
		this.button2.UseUnderline = true;
		this.button2.Label = global::Mono.Unix.Catalog.GetString("Adicionar");
		global::Gtk.Image w3 = new global::Gtk.Image();
		w3.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-add", global::Gtk.IconSize.Menu);
		this.button2.Image = w3;
		this.fixed1.Add(this.button2);
		global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.button2]));
		w4.X = 97;
		w4.Y = 5;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.button3 = new global::Gtk.Button();
		this.button3.CanFocus = true;
		this.button3.Name = "button3";
		this.button3.UseUnderline = true;
		this.button3.Label = global::Mono.Unix.Catalog.GetString("Editar");
		global::Gtk.Image w5 = new global::Gtk.Image();
		w5.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-edit", global::Gtk.IconSize.Menu);
		this.button3.Image = w5;
		this.fixed1.Add(this.button3);
		global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.button3]));
		w6.X = 195;
		w6.Y = 5;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.button4 = new global::Gtk.Button();
		this.button4.CanFocus = true;
		this.button4.Name = "button4";
		this.button4.UseUnderline = true;
		this.button4.Label = global::Mono.Unix.Catalog.GetString("Atualizar");
		global::Gtk.Image w7 = new global::Gtk.Image();
		w7.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-refresh", global::Gtk.IconSize.Menu);
		this.button4.Image = w7;
		this.fixed1.Add(this.button4);
		global::Gtk.Fixed.FixedChild w8 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.button4]));
		w8.X = 269;
		w8.Y = 5;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.textview2 = new global::Gtk.TextView();
		this.textview2.WidthRequest = 750;
		this.textview2.HeightRequest = 500;
		this.textview2.Sensitive = false;
		this.textview2.CanFocus = true;
		this.textview2.Name = "textview2";
		this.GtkScrolledWindow.Add(this.textview2);
		this.fixed1.Add(this.GtkScrolledWindow);
		global::Gtk.Fixed.FixedChild w10 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.GtkScrolledWindow]));
		w10.X = 11;
		w10.Y = 57;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.button1 = new global::Gtk.Button();
		this.button1.CanFocus = true;
		this.button1.Name = "button1";
		this.button1.UseUnderline = true;
		this.button1.Label = global::Mono.Unix.Catalog.GetString("Sobre");
		global::Gtk.Image w11 = new global::Gtk.Image();
		w11.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-about", global::Gtk.IconSize.Menu);
		this.button1.Image = w11;
		this.fixed1.Add(this.button1);
		global::Gtk.Fixed.FixedChild w12 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.button1]));
		w12.X = 363;
		w12.Y = 5;
		this.Add(this.fixed1);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 776;
		this.DefaultHeight = 572;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.load.Clicked += new global::System.EventHandler(this.OnLoadClicked);
		this.button2.Clicked += new global::System.EventHandler(this.OnButton2Clicked);
	}
}
