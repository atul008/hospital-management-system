
// This file has been generated by the GUI designer. Do not modify.
namespace hm
{
	public partial class calculateBill
	{
		private global::Gtk.VBox vbox1;
		private global::Gtk.Image image29;
		private global::Gtk.Label label8;
		private global::Gtk.Entry entry7;
		private global::Gtk.Button button2;
		private global::Gtk.Label label12;
		private global::Gtk.HBox hbox1;
		private global::Gtk.Label label10;
		private global::Gtk.Label label9;
		private global::Gtk.Label label1;
		private global::Gtk.Table table2;
		private global::Gtk.Entry entry1;
		private global::Gtk.Entry entry2;
		private global::Gtk.Entry entry3;
		private global::Gtk.Entry entry4;
		private global::Gtk.Entry entry5;
		private global::Gtk.Entry entry6;
		private global::Gtk.Label label2;
		private global::Gtk.Label label3;
		private global::Gtk.Label label4;
		private global::Gtk.Label label5;
		private global::Gtk.Label label6;
		private global::Gtk.Label label7;
		private global::Gtk.HBox hbox2;
		private global::Gtk.Button button5;
		private global::Gtk.Button button6;
		private global::Gtk.ScrolledWindow GtkScrolledWindow1;
		private global::Gtk.TextView textview4;
		private global::Gtk.Button button7;
		private global::Gtk.ScrolledWindow GtkScrolledWindow2;
		private global::Gtk.TextView textview5;
		private global::Gtk.Button button4;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget hm.calculateBill
			this.Name = "hm.calculateBill";
			this.Title = global::Mono.Unix.Catalog.GetString ("Update Bill");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child hm.calculateBill.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.image29 = new global::Gtk.Image ();
			this.image29.Name = "image29";
			this.image29.Pixbuf = new global::Gdk.Pixbuf (global::System.IO.Path.Combine (global::System.AppDomain.CurrentDomain.BaseDirectory, "./plant.ico"));
			this.vbox1.Add (this.image29);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.image29]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.label8 = new global::Gtk.Label ();
			this.label8.Name = "label8";
			this.label8.LabelProp = global::Mono.Unix.Catalog.GetString ("Enter Patient's Registration Number");
			this.vbox1.Add (this.label8);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.label8]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.entry7 = new global::Gtk.Entry ();
			this.entry7.CanFocus = true;
			this.entry7.Name = "entry7";
			this.entry7.IsEditable = true;
			this.entry7.InvisibleChar = '•';
			this.vbox1.Add (this.entry7);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.entry7]));
			w3.Position = 2;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.button2 = new global::Gtk.Button ();
			this.button2.CanFocus = true;
			this.button2.Name = "button2";
			this.button2.UseUnderline = true;
			// Container child button2.Gtk.Container+ContainerChild
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
			w8.LabelProp = global::Mono.Unix.Catalog.GetString ("Search Patient");
			w8.UseUnderline = true;
			w5.Add (w8);
			w4.Add (w5);
			this.button2.Add (w4);
			this.vbox1.Add (this.button2);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.button2]));
			w12.Position = 3;
			w12.Expand = false;
			w12.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.label12 = new global::Gtk.Label ();
			this.label12.Name = "label12";
			this.vbox1.Add (this.label12);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.label12]));
			w13.Position = 4;
			w13.Expand = false;
			w13.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.label10 = new global::Gtk.Label ();
			this.label10.Name = "label10";
			this.label10.LabelProp = global::Mono.Unix.Catalog.GetString ("Name of Patient");
			this.hbox1.Add (this.label10);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.label10]));
			w14.Position = 0;
			w14.Expand = false;
			w14.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.label9 = new global::Gtk.Label ();
			this.label9.Name = "label9";
			this.hbox1.Add (this.label9);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.label9]));
			w15.Position = 1;
			w15.Expand = false;
			w15.Fill = false;
			this.vbox1.Add (this.hbox1);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox1]));
			w16.Position = 5;
			w16.Expand = false;
			w16.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Add the Charges");
			this.vbox1.Add (this.label1);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.label1]));
			w17.Position = 6;
			w17.Expand = false;
			w17.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.table2 = new global::Gtk.Table (((uint)(6)), ((uint)(2)), false);
			this.table2.Name = "table2";
			this.table2.RowSpacing = ((uint)(6));
			this.table2.ColumnSpacing = ((uint)(6));
			// Container child table2.Gtk.Table+TableChild
			this.entry1 = new global::Gtk.Entry ();
			this.entry1.CanFocus = true;
			this.entry1.Name = "entry1";
			this.entry1.IsEditable = true;
			this.entry1.InvisibleChar = '•';
			this.table2.Add (this.entry1);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.table2 [this.entry1]));
			w18.LeftAttach = ((uint)(1));
			w18.RightAttach = ((uint)(2));
			w18.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.entry2 = new global::Gtk.Entry ();
			this.entry2.CanFocus = true;
			this.entry2.Name = "entry2";
			this.entry2.IsEditable = true;
			this.entry2.InvisibleChar = '•';
			this.table2.Add (this.entry2);
			global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.table2 [this.entry2]));
			w19.TopAttach = ((uint)(1));
			w19.BottomAttach = ((uint)(2));
			w19.LeftAttach = ((uint)(1));
			w19.RightAttach = ((uint)(2));
			w19.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.entry3 = new global::Gtk.Entry ();
			this.entry3.CanFocus = true;
			this.entry3.Name = "entry3";
			this.entry3.IsEditable = true;
			this.entry3.InvisibleChar = '•';
			this.table2.Add (this.entry3);
			global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.table2 [this.entry3]));
			w20.TopAttach = ((uint)(2));
			w20.BottomAttach = ((uint)(3));
			w20.LeftAttach = ((uint)(1));
			w20.RightAttach = ((uint)(2));
			w20.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.entry4 = new global::Gtk.Entry ();
			this.entry4.CanFocus = true;
			this.entry4.Name = "entry4";
			this.entry4.IsEditable = true;
			this.entry4.InvisibleChar = '•';
			this.table2.Add (this.entry4);
			global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.table2 [this.entry4]));
			w21.TopAttach = ((uint)(3));
			w21.BottomAttach = ((uint)(4));
			w21.LeftAttach = ((uint)(1));
			w21.RightAttach = ((uint)(2));
			w21.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.entry5 = new global::Gtk.Entry ();
			this.entry5.CanFocus = true;
			this.entry5.Name = "entry5";
			this.entry5.IsEditable = true;
			this.entry5.InvisibleChar = '•';
			this.table2.Add (this.entry5);
			global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.table2 [this.entry5]));
			w22.TopAttach = ((uint)(4));
			w22.BottomAttach = ((uint)(5));
			w22.LeftAttach = ((uint)(1));
			w22.RightAttach = ((uint)(2));
			w22.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.entry6 = new global::Gtk.Entry ();
			this.entry6.CanFocus = true;
			this.entry6.Name = "entry6";
			this.entry6.IsEditable = true;
			this.entry6.InvisibleChar = '•';
			this.table2.Add (this.entry6);
			global::Gtk.Table.TableChild w23 = ((global::Gtk.Table.TableChild)(this.table2 [this.entry6]));
			w23.TopAttach = ((uint)(5));
			w23.BottomAttach = ((uint)(6));
			w23.LeftAttach = ((uint)(1));
			w23.RightAttach = ((uint)(2));
			w23.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Registration Fee");
			this.table2.Add (this.label2);
			global::Gtk.Table.TableChild w24 = ((global::Gtk.Table.TableChild)(this.table2 [this.label2]));
			w24.XOptions = ((global::Gtk.AttachOptions)(4));
			w24.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Lab Fee ");
			this.table2.Add (this.label3);
			global::Gtk.Table.TableChild w25 = ((global::Gtk.Table.TableChild)(this.table2 [this.label3]));
			w25.TopAttach = ((uint)(1));
			w25.BottomAttach = ((uint)(2));
			w25.XOptions = ((global::Gtk.AttachOptions)(4));
			w25.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Medicine Charge");
			this.table2.Add (this.label4);
			global::Gtk.Table.TableChild w26 = ((global::Gtk.Table.TableChild)(this.table2 [this.label4]));
			w26.TopAttach = ((uint)(2));
			w26.BottomAttach = ((uint)(3));
			w26.XOptions = ((global::Gtk.AttachOptions)(4));
			w26.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("Room Charge");
			this.table2.Add (this.label5);
			global::Gtk.Table.TableChild w27 = ((global::Gtk.Table.TableChild)(this.table2 [this.label5]));
			w27.TopAttach = ((uint)(3));
			w27.BottomAttach = ((uint)(4));
			w27.XOptions = ((global::Gtk.AttachOptions)(4));
			w27.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label6 = new global::Gtk.Label ();
			this.label6.Name = "label6";
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("Doctor Fee");
			this.table2.Add (this.label6);
			global::Gtk.Table.TableChild w28 = ((global::Gtk.Table.TableChild)(this.table2 [this.label6]));
			w28.TopAttach = ((uint)(4));
			w28.BottomAttach = ((uint)(5));
			w28.XOptions = ((global::Gtk.AttachOptions)(4));
			w28.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label7 = new global::Gtk.Label ();
			this.label7.Name = "label7";
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString ("Other charges");
			this.table2.Add (this.label7);
			global::Gtk.Table.TableChild w29 = ((global::Gtk.Table.TableChild)(this.table2 [this.label7]));
			w29.TopAttach = ((uint)(5));
			w29.BottomAttach = ((uint)(6));
			w29.XOptions = ((global::Gtk.AttachOptions)(4));
			w29.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox1.Add (this.table2);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.table2]));
			w30.Position = 7;
			w30.Expand = false;
			w30.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.button5 = new global::Gtk.Button ();
			this.button5.CanFocus = true;
			this.button5.Name = "button5";
			this.button5.UseUnderline = true;
			// Container child button5.Gtk.Container+ContainerChild
			global::Gtk.Alignment w31 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w32 = new global::Gtk.HBox ();
			w32.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w33 = new global::Gtk.Image ();
			w33.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-refresh", global::Gtk.IconSize.LargeToolbar);
			w32.Add (w33);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w35 = new global::Gtk.Label ();
			w35.LabelProp = global::Mono.Unix.Catalog.GetString ("Reset");
			w35.UseUnderline = true;
			w32.Add (w35);
			w31.Add (w32);
			this.button5.Add (w31);
			this.hbox2.Add (this.button5);
			global::Gtk.Box.BoxChild w39 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.button5]));
			w39.Position = 0;
			w39.Expand = false;
			w39.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.button6 = new global::Gtk.Button ();
			this.button6.CanFocus = true;
			this.button6.Name = "button6";
			this.button6.UseUnderline = true;
			// Container child button6.Gtk.Container+ContainerChild
			global::Gtk.Alignment w40 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w41 = new global::Gtk.HBox ();
			w41.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w42 = new global::Gtk.Image ();
			w42.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "stock_add-bookmark", global::Gtk.IconSize.Menu);
			w41.Add (w42);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w44 = new global::Gtk.Label ();
			w44.LabelProp = global::Mono.Unix.Catalog.GetString ("Total");
			w44.UseUnderline = true;
			w41.Add (w44);
			w40.Add (w41);
			this.button6.Add (w40);
			this.hbox2.Add (this.button6);
			global::Gtk.Box.BoxChild w48 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.button6]));
			w48.Position = 1;
			w48.Expand = false;
			w48.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
			this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
			this.textview4 = new global::Gtk.TextView ();
			this.textview4.CanFocus = true;
			this.textview4.Name = "textview4";
			this.GtkScrolledWindow1.Add (this.textview4);
			this.hbox2.Add (this.GtkScrolledWindow1);
			global::Gtk.Box.BoxChild w50 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.GtkScrolledWindow1]));
			w50.Position = 2;
			this.vbox1.Add (this.hbox2);
			global::Gtk.Box.BoxChild w51 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox2]));
			w51.Position = 8;
			w51.Expand = false;
			w51.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.button7 = new global::Gtk.Button ();
			this.button7.CanFocus = true;
			this.button7.Name = "button7";
			this.button7.UseUnderline = true;
			// Container child button7.Gtk.Container+ContainerChild
			global::Gtk.Alignment w52 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w53 = new global::Gtk.HBox ();
			w53.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w54 = new global::Gtk.Image ();
			w54.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-floppy", global::Gtk.IconSize.LargeToolbar);
			w53.Add (w54);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w56 = new global::Gtk.Label ();
			w56.LabelProp = global::Mono.Unix.Catalog.GetString ("Udate Bill");
			w56.UseUnderline = true;
			w53.Add (w56);
			w52.Add (w53);
			this.button7.Add (w52);
			this.vbox1.Add (this.button7);
			global::Gtk.Box.BoxChild w60 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.button7]));
			w60.Position = 9;
			w60.Expand = false;
			w60.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.GtkScrolledWindow2 = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow2.Name = "GtkScrolledWindow2";
			this.GtkScrolledWindow2.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow2.Gtk.Container+ContainerChild
			this.textview5 = new global::Gtk.TextView ();
			this.textview5.CanFocus = true;
			this.textview5.Name = "textview5";
			this.textview5.Editable = false;
			this.textview5.CursorVisible = false;
			this.GtkScrolledWindow2.Add (this.textview5);
			this.vbox1.Add (this.GtkScrolledWindow2);
			global::Gtk.Box.BoxChild w62 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.GtkScrolledWindow2]));
			w62.Position = 10;
			// Container child vbox1.Gtk.Box+BoxChild
			this.button4 = new global::Gtk.Button ();
			this.button4.CanFocus = true;
			this.button4.Name = "button4";
			this.button4.UseUnderline = true;
			// Container child button4.Gtk.Container+ContainerChild
			global::Gtk.Alignment w63 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w64 = new global::Gtk.HBox ();
			w64.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w65 = new global::Gtk.Image ();
			w65.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-close", global::Gtk.IconSize.LargeToolbar);
			w64.Add (w65);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w67 = new global::Gtk.Label ();
			w67.LabelProp = global::Mono.Unix.Catalog.GetString ("Close");
			w67.UseUnderline = true;
			w64.Add (w67);
			w63.Add (w64);
			this.button4.Add (w63);
			this.vbox1.Add (this.button4);
			global::Gtk.Box.BoxChild w71 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.button4]));
			w71.Position = 11;
			w71.Expand = false;
			w71.Fill = false;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 656;
			this.Show ();
			this.button2.Clicked += new global::System.EventHandler (this.OnButton2Clicked);
			this.button5.Clicked += new global::System.EventHandler (this.OnButton5Clicked);
			this.button6.Clicked += new global::System.EventHandler (this.OnButton6Clicked);
			this.button7.Clicked += new global::System.EventHandler (this.OnButton7Clicked);
			this.button4.Clicked += new global::System.EventHandler (this.OnButton4Clicked);
		}
	}
}
