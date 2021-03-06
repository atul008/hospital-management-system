
// This file has been generated by the GUI designer. Do not modify.
namespace hm
{
	public partial class PatientInfo
	{
		private global::Gtk.VBox vbox3;
		private global::Gtk.VBox vbox5;
		private global::Gtk.Label label1;
		private global::Gtk.Image image834;
		private global::Gtk.Table table1;
		private global::Gtk.Button button1;
		private global::Gtk.Button button2;
		private global::Gtk.ComboBoxEntry comboboxentry2;
		private global::Gtk.Entry entry1;
		private global::Gtk.Entry entry2;
		private global::Gtk.Entry entry3;
		private global::Gtk.Entry entry7;
		private global::Gtk.HBox hbox3;
		private global::Gtk.RadioButton radiobutton3;
		private global::Gtk.RadioButton radiobutton4;
		private global::Gtk.Label label11;
		private global::Gtk.Label label2;
		private global::Gtk.Label label3;
		private global::Gtk.Label label4;
		private global::Gtk.Label label5;
		private global::Gtk.Label label8;
		private global::Gtk.HBox hbox1;
		private global::Gtk.Label label6;
		private global::Gtk.ScrolledWindow GtkScrolledWindow1;
		private global::Gtk.TextView textview2;
		private global::Gtk.VBox vbox6;
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		private global::Gtk.TextView textview3;
		private global::Gtk.Button button3;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget hm.PatientInfo
			this.Name = "hm.PatientInfo";
			this.Title = global::Mono.Unix.Catalog.GetString ("Patient Registration");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.AllowShrink = true;
			this.DefaultWidth = 370;
			this.DefaultHeight = 600;
			// Container child hm.PatientInfo.Gtk.Container+ContainerChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.vbox5 = new global::Gtk.VBox ();
			this.vbox5.Name = "vbox5";
			this.vbox5.Spacing = 6;
			// Container child vbox5.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label ();
			this.label1.HeightRequest = 0;
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Registration Form");
			this.label1.Justify = ((global::Gtk.Justification)(2));
			this.label1.Ellipsize = ((global::Pango.EllipsizeMode)(2));
			this.vbox5.Add (this.label1);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.label1]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.image834 = new global::Gtk.Image ();
			this.image834.Name = "image834";
			this.image834.Pixbuf = new global::Gdk.Pixbuf (global::System.IO.Path.Combine (global::System.AppDomain.CurrentDomain.BaseDirectory, "./medical_report.ico"));
			this.vbox5.Add (this.image834);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.image834]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table (((uint)(7)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.button1 = new global::Gtk.Button ();
			this.button1.CanFocus = true;
			this.button1.Name = "button1";
			this.button1.UseUnderline = true;
			// Container child button1.Gtk.Container+ContainerChild
			global::Gtk.Alignment w3 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w4 = new global::Gtk.HBox ();
			w4.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w5 = new global::Gtk.Image ();
			w5.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-refresh", global::Gtk.IconSize.LargeToolbar);
			w4.Add (w5);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w7 = new global::Gtk.Label ();
			w7.LabelProp = global::Mono.Unix.Catalog.GetString ("Reset Form");
			w7.UseUnderline = true;
			w4.Add (w7);
			w3.Add (w4);
			this.button1.Add (w3);
			this.table1.Add (this.button1);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table1 [this.button1]));
			w11.TopAttach = ((uint)(6));
			w11.BottomAttach = ((uint)(7));
			w11.XOptions = ((global::Gtk.AttachOptions)(0));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.button2 = new global::Gtk.Button ();
			this.button2.CanFocus = true;
			this.button2.Name = "button2";
			this.button2.UseUnderline = true;
			// Container child button2.Gtk.Container+ContainerChild
			global::Gtk.Alignment w12 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w13 = new global::Gtk.HBox ();
			w13.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w14 = new global::Gtk.Image ();
			w14.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-add", global::Gtk.IconSize.LargeToolbar);
			w13.Add (w14);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w16 = new global::Gtk.Label ();
			w16.LabelProp = global::Mono.Unix.Catalog.GetString ("Register Patient");
			w16.UseUnderline = true;
			w13.Add (w16);
			w12.Add (w13);
			this.button2.Add (w12);
			this.table1.Add (this.button2);
			global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.table1 [this.button2]));
			w20.TopAttach = ((uint)(6));
			w20.BottomAttach = ((uint)(7));
			w20.LeftAttach = ((uint)(1));
			w20.RightAttach = ((uint)(2));
			w20.XOptions = ((global::Gtk.AttachOptions)(4));
			w20.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.comboboxentry2 = global::Gtk.ComboBoxEntry.NewText ();
			this.comboboxentry2.AppendText ("");
			this.comboboxentry2.AppendText (global::Mono.Unix.Catalog.GetString ("Accident and emergency (A&E)"));
			this.comboboxentry2.AppendText (global::Mono.Unix.Catalog.GetString ("Anaesthetics"));
			this.comboboxentry2.AppendText (global::Mono.Unix.Catalog.GetString ("Cardiology "));
			this.comboboxentry2.AppendText (global::Mono.Unix.Catalog.GetString ("Critical Care"));
			this.comboboxentry2.AppendText (global::Mono.Unix.Catalog.GetString ("Gynaecology"));
			this.comboboxentry2.AppendText (global::Mono.Unix.Catalog.GetString ("Haematology"));
			this.comboboxentry2.Name = "comboboxentry2";
			this.comboboxentry2.Active = 0;
			this.table1.Add (this.comboboxentry2);
			global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.table1 [this.comboboxentry2]));
			w21.LeftAttach = ((uint)(1));
			w21.RightAttach = ((uint)(2));
			w21.XOptions = ((global::Gtk.AttachOptions)(4));
			w21.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entry1 = new global::Gtk.Entry ();
			this.entry1.CanFocus = true;
			this.entry1.Name = "entry1";
			this.entry1.IsEditable = true;
			this.entry1.InvisibleChar = '•';
			this.table1.Add (this.entry1);
			global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.table1 [this.entry1]));
			w22.TopAttach = ((uint)(5));
			w22.BottomAttach = ((uint)(6));
			w22.LeftAttach = ((uint)(1));
			w22.RightAttach = ((uint)(2));
			w22.XOptions = ((global::Gtk.AttachOptions)(4));
			w22.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entry2 = new global::Gtk.Entry ();
			this.entry2.CanFocus = true;
			this.entry2.Name = "entry2";
			this.entry2.IsEditable = true;
			this.entry2.InvisibleChar = '•';
			this.table1.Add (this.entry2);
			global::Gtk.Table.TableChild w23 = ((global::Gtk.Table.TableChild)(this.table1 [this.entry2]));
			w23.TopAttach = ((uint)(1));
			w23.BottomAttach = ((uint)(2));
			w23.LeftAttach = ((uint)(1));
			w23.RightAttach = ((uint)(2));
			w23.XOptions = ((global::Gtk.AttachOptions)(4));
			w23.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entry3 = new global::Gtk.Entry ();
			this.entry3.CanFocus = true;
			this.entry3.Name = "entry3";
			this.entry3.IsEditable = true;
			this.entry3.InvisibleChar = '•';
			this.table1.Add (this.entry3);
			global::Gtk.Table.TableChild w24 = ((global::Gtk.Table.TableChild)(this.table1 [this.entry3]));
			w24.TopAttach = ((uint)(2));
			w24.BottomAttach = ((uint)(3));
			w24.LeftAttach = ((uint)(1));
			w24.RightAttach = ((uint)(2));
			w24.XOptions = ((global::Gtk.AttachOptions)(4));
			w24.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entry7 = new global::Gtk.Entry ();
			this.entry7.CanFocus = true;
			this.entry7.Name = "entry7";
			this.entry7.IsEditable = true;
			this.entry7.InvisibleChar = '•';
			this.table1.Add (this.entry7);
			global::Gtk.Table.TableChild w25 = ((global::Gtk.Table.TableChild)(this.table1 [this.entry7]));
			w25.TopAttach = ((uint)(4));
			w25.BottomAttach = ((uint)(5));
			w25.LeftAttach = ((uint)(1));
			w25.RightAttach = ((uint)(2));
			w25.XOptions = ((global::Gtk.AttachOptions)(4));
			w25.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hbox3 = new global::Gtk.HBox ();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.radiobutton3 = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Male"));
			this.radiobutton3.CanFocus = true;
			this.radiobutton3.Name = "radiobutton3";
			this.radiobutton3.DrawIndicator = true;
			this.radiobutton3.UseUnderline = true;
			this.radiobutton3.Group = new global::GLib.SList (global::System.IntPtr.Zero);
			this.hbox3.Add (this.radiobutton3);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.radiobutton3]));
			w26.Position = 0;
			w26.Expand = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.radiobutton4 = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Female"));
			this.radiobutton4.CanFocus = true;
			this.radiobutton4.Name = "radiobutton4";
			this.radiobutton4.DrawIndicator = true;
			this.radiobutton4.UseUnderline = true;
			this.radiobutton4.Group = this.radiobutton3.Group;
			this.hbox3.Add (this.radiobutton4);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.radiobutton4]));
			w27.Position = 1;
			this.table1.Add (this.hbox3);
			global::Gtk.Table.TableChild w28 = ((global::Gtk.Table.TableChild)(this.table1 [this.hbox3]));
			w28.TopAttach = ((uint)(3));
			w28.BottomAttach = ((uint)(4));
			w28.LeftAttach = ((uint)(1));
			w28.RightAttach = ((uint)(2));
			w28.XOptions = ((global::Gtk.AttachOptions)(4));
			w28.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label11 = new global::Gtk.Label ();
			this.label11.Name = "label11";
			this.label11.LabelProp = global::Mono.Unix.Catalog.GetString ("Department");
			this.table1.Add (this.label11);
			global::Gtk.Table.TableChild w29 = ((global::Gtk.Table.TableChild)(this.table1 [this.label11]));
			w29.XOptions = ((global::Gtk.AttachOptions)(4));
			w29.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Health Problem");
			this.table1.Add (this.label2);
			global::Gtk.Table.TableChild w30 = ((global::Gtk.Table.TableChild)(this.table1 [this.label2]));
			w30.TopAttach = ((uint)(5));
			w30.BottomAttach = ((uint)(6));
			w30.XOptions = ((global::Gtk.AttachOptions)(4));
			w30.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Name");
			this.table1.Add (this.label3);
			global::Gtk.Table.TableChild w31 = ((global::Gtk.Table.TableChild)(this.table1 [this.label3]));
			w31.TopAttach = ((uint)(1));
			w31.BottomAttach = ((uint)(2));
			w31.XOptions = ((global::Gtk.AttachOptions)(4));
			w31.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Age");
			this.table1.Add (this.label4);
			global::Gtk.Table.TableChild w32 = ((global::Gtk.Table.TableChild)(this.table1 [this.label4]));
			w32.TopAttach = ((uint)(2));
			w32.BottomAttach = ((uint)(3));
			w32.XOptions = ((global::Gtk.AttachOptions)(4));
			w32.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("sex");
			this.table1.Add (this.label5);
			global::Gtk.Table.TableChild w33 = ((global::Gtk.Table.TableChild)(this.table1 [this.label5]));
			w33.TopAttach = ((uint)(3));
			w33.BottomAttach = ((uint)(4));
			w33.XOptions = ((global::Gtk.AttachOptions)(4));
			w33.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label8 = new global::Gtk.Label ();
			this.label8.Name = "label8";
			this.label8.LabelProp = global::Mono.Unix.Catalog.GetString ("Phone Number");
			this.table1.Add (this.label8);
			global::Gtk.Table.TableChild w34 = ((global::Gtk.Table.TableChild)(this.table1 [this.label8]));
			w34.TopAttach = ((uint)(4));
			w34.BottomAttach = ((uint)(5));
			w34.XOptions = ((global::Gtk.AttachOptions)(4));
			w34.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox5.Add (this.table1);
			global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.table1]));
			w35.Position = 2;
			w35.Expand = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.label6 = new global::Gtk.Label ();
			this.label6.Name = "label6";
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("Auto Generated Registration No.");
			this.hbox1.Add (this.label6);
			global::Gtk.Box.BoxChild w36 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.label6]));
			w36.Position = 0;
			w36.Expand = false;
			w36.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
			this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
			this.textview2 = new global::Gtk.TextView ();
			this.textview2.CanFocus = true;
			this.textview2.Name = "textview2";
			this.textview2.Editable = false;
			this.textview2.CursorVisible = false;
			this.GtkScrolledWindow1.Add (this.textview2);
			this.hbox1.Add (this.GtkScrolledWindow1);
			global::Gtk.Box.BoxChild w38 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.GtkScrolledWindow1]));
			w38.Position = 1;
			this.vbox5.Add (this.hbox1);
			global::Gtk.Box.BoxChild w39 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.hbox1]));
			w39.Position = 3;
			w39.Expand = false;
			w39.Fill = false;
			this.vbox3.Add (this.vbox5);
			global::Gtk.Box.BoxChild w40 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.vbox5]));
			w40.Position = 0;
			w40.Expand = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.vbox6 = new global::Gtk.VBox ();
			this.vbox6.Name = "vbox6";
			this.vbox6.Spacing = 6;
			// Container child vbox6.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.textview3 = new global::Gtk.TextView ();
			this.textview3.CanFocus = true;
			this.textview3.Name = "textview3";
			this.textview3.Editable = false;
			this.textview3.CursorVisible = false;
			this.textview3.Justification = ((global::Gtk.Justification)(2));
			this.GtkScrolledWindow.Add (this.textview3);
			this.vbox6.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w42 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.GtkScrolledWindow]));
			w42.Position = 0;
			// Container child vbox6.Gtk.Box+BoxChild
			this.button3 = new global::Gtk.Button ();
			this.button3.CanFocus = true;
			this.button3.Name = "button3";
			this.button3.UseUnderline = true;
			// Container child button3.Gtk.Container+ContainerChild
			global::Gtk.Alignment w43 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w44 = new global::Gtk.HBox ();
			w44.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w45 = new global::Gtk.Image ();
			w45.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-close", global::Gtk.IconSize.LargeToolbar);
			w44.Add (w45);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w47 = new global::Gtk.Label ();
			w47.LabelProp = global::Mono.Unix.Catalog.GetString ("Close");
			w47.UseUnderline = true;
			w44.Add (w47);
			w43.Add (w44);
			this.button3.Add (w43);
			this.vbox6.Add (this.button3);
			global::Gtk.Box.BoxChild w51 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.button3]));
			w51.Position = 1;
			w51.Expand = false;
			w51.Fill = false;
			this.vbox3.Add (this.vbox6);
			global::Gtk.Box.BoxChild w52 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.vbox6]));
			w52.Position = 1;
			this.Add (this.vbox3);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Show ();
			this.button2.Clicked += new global::System.EventHandler (this.OnButton2Clicked);
			this.button1.Clicked += new global::System.EventHandler (this.OnButton1Clicked);
			this.button3.Clicked += new global::System.EventHandler (this.OnButton3Clicked);
		}
	}
}
