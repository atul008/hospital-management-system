
// This file has been generated by the GUI designer. Do not modify.
namespace hm
{
	public partial class seachStaff
	{
		private global::Gtk.VBox vbox7;
		private global::Gtk.Image image311;
		private global::Gtk.Label label23;
		private global::Gtk.Entry entry7;
		private global::Gtk.Button button10;
		private global::Gtk.Label label7;
		private global::Gtk.Entry entry3;
		private global::Gtk.Button button2;
		private global::Gtk.Label label8;
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		private global::Gtk.TextView textview2;
		private global::Gtk.Button button3;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget hm.seachStaff
			this.Name = "hm.seachStaff";
			this.Title = global::Mono.Unix.Catalog.GetString ("Search Staff");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.DefaultWidth = 400;
			this.DefaultHeight = 600;
			// Container child hm.seachStaff.Gtk.Container+ContainerChild
			this.vbox7 = new global::Gtk.VBox ();
			this.vbox7.Name = "vbox7";
			this.vbox7.Spacing = 6;
			// Container child vbox7.Gtk.Box+BoxChild
			this.image311 = new global::Gtk.Image ();
			this.image311.Name = "image311";
			this.image311.Pixbuf = new global::Gdk.Pixbuf (global::System.IO.Path.Combine (global::System.AppDomain.CurrentDomain.BaseDirectory, "./head physician.ico"));
			this.vbox7.Add (this.image311);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.image311]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox7.Gtk.Box+BoxChild
			this.label23 = new global::Gtk.Label ();
			this.label23.Name = "label23";
			this.label23.LabelProp = global::Mono.Unix.Catalog.GetString ("Please Enter Staff Member's ID");
			this.vbox7.Add (this.label23);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.label23]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox7.Gtk.Box+BoxChild
			this.entry7 = new global::Gtk.Entry ();
			this.entry7.CanFocus = true;
			this.entry7.Name = "entry7";
			this.entry7.IsEditable = true;
			this.entry7.InvisibleChar = '•';
			this.vbox7.Add (this.entry7);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.entry7]));
			w3.Position = 2;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox7.Gtk.Box+BoxChild
			this.button10 = new global::Gtk.Button ();
			this.button10.CanFocus = true;
			this.button10.Name = "button10";
			this.button10.UseUnderline = true;
			// Container child button10.Gtk.Container+ContainerChild
			global::Gtk.Alignment w4 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w5 = new global::Gtk.HBox ();
			w5.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w6 = new global::Gtk.Image ();
			w6.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-find", global::Gtk.IconSize.LargeToolbar);
			w5.Add (w6);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w8 = new global::Gtk.Label ();
			w8.LabelProp = global::Mono.Unix.Catalog.GetString ("Search by ID");
			w8.UseUnderline = true;
			w5.Add (w8);
			w4.Add (w5);
			this.button10.Add (w4);
			this.vbox7.Add (this.button10);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.button10]));
			w12.Position = 3;
			w12.Expand = false;
			w12.Fill = false;
			// Container child vbox7.Gtk.Box+BoxChild
			this.label7 = new global::Gtk.Label ();
			this.label7.Name = "label7";
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString ("Enter Staff Member's Name");
			this.vbox7.Add (this.label7);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.label7]));
			w13.Position = 4;
			w13.Expand = false;
			w13.Fill = false;
			// Container child vbox7.Gtk.Box+BoxChild
			this.entry3 = new global::Gtk.Entry ();
			this.entry3.CanFocus = true;
			this.entry3.Name = "entry3";
			this.entry3.IsEditable = true;
			this.entry3.InvisibleChar = '•';
			this.vbox7.Add (this.entry3);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.entry3]));
			w14.Position = 5;
			w14.Expand = false;
			w14.Fill = false;
			// Container child vbox7.Gtk.Box+BoxChild
			this.button2 = new global::Gtk.Button ();
			this.button2.CanFocus = true;
			this.button2.Name = "button2";
			this.button2.UseUnderline = true;
			// Container child button2.Gtk.Container+ContainerChild
			global::Gtk.Alignment w15 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w16 = new global::Gtk.HBox ();
			w16.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w17 = new global::Gtk.Image ();
			w17.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-find", global::Gtk.IconSize.LargeToolbar);
			w16.Add (w17);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w19 = new global::Gtk.Label ();
			w19.LabelProp = global::Mono.Unix.Catalog.GetString ("Search by Name");
			w19.UseUnderline = true;
			w16.Add (w19);
			w15.Add (w16);
			this.button2.Add (w15);
			this.vbox7.Add (this.button2);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.button2]));
			w23.Position = 6;
			w23.Expand = false;
			w23.Fill = false;
			// Container child vbox7.Gtk.Box+BoxChild
			this.label8 = new global::Gtk.Label ();
			this.label8.Name = "label8";
			this.label8.LabelProp = global::Mono.Unix.Catalog.GetString ("Search Results");
			this.vbox7.Add (this.label8);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.label8]));
			w24.Position = 7;
			w24.Expand = false;
			w24.Fill = false;
			// Container child vbox7.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.textview2 = new global::Gtk.TextView ();
			this.textview2.CanFocus = true;
			this.textview2.Name = "textview2";
			this.textview2.Editable = false;
			this.textview2.CursorVisible = false;
			this.GtkScrolledWindow.Add (this.textview2);
			this.vbox7.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.GtkScrolledWindow]));
			w26.Position = 8;
			// Container child vbox7.Gtk.Box+BoxChild
			this.button3 = new global::Gtk.Button ();
			this.button3.CanFocus = true;
			this.button3.Name = "button3";
			this.button3.UseUnderline = true;
			// Container child button3.Gtk.Container+ContainerChild
			global::Gtk.Alignment w27 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w28 = new global::Gtk.HBox ();
			w28.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w29 = new global::Gtk.Image ();
			w29.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-close", global::Gtk.IconSize.LargeToolbar);
			w28.Add (w29);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w31 = new global::Gtk.Label ();
			w31.LabelProp = global::Mono.Unix.Catalog.GetString ("Close");
			w31.UseUnderline = true;
			w28.Add (w31);
			w27.Add (w28);
			this.button3.Add (w27);
			this.vbox7.Add (this.button3);
			global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.button3]));
			w35.Position = 9;
			w35.Expand = false;
			w35.Fill = false;
			this.Add (this.vbox7);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Show ();
			this.button10.Clicked += new global::System.EventHandler (this.OnButton10Clicked);
			this.button2.Clicked += new global::System.EventHandler (this.OnButton2Clicked);
			this.button3.Clicked += new global::System.EventHandler (this.OnButton3Clicked);
		}
	}
}
