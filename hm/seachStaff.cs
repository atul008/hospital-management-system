using System;
using Gtk;
using hm;
using System.Data;
using MySql.Data.MySqlClient;

namespace hm
{
	public partial class seachStaff : Gtk.Window
	{
		public seachStaff () : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}
		protected void OnButton10Clicked (object sender, EventArgs e)
		{
			if (!(entry7.Text.Equals(""))) {
				entry3.Text = "";
				string cs = "Server=localhost;" + "Database=hospital;" + "User ID=root;" + "Password=rahul008;" + "Pooling=false";
				MySqlConnection conn;
				MySqlDataReader reader;
				try {
					conn = new MySqlConnection (cs);
					conn.Open ();
					string str = "SELECT * FROM hospital.staff where uid = " + entry7.Text + ";";
					MySqlCommand cmd = new MySqlCommand (str, conn);
					reader = cmd.ExecuteReader ();
					if (reader.Read ()) {
			
						textview2.Buffer.Text = "Staff Member Details\n\n" + 
							"UId:  " + reader.GetString (0) + " \n" +
							"Name:  " + reader.GetString (1) + "\n" +
							"Department: " + reader.GetString (2) + "\n" +
							"Staff Category: " + reader.GetString (3) + " \n " +
							"Age: " + reader.GetString (5) + "\n" +
							"Gender: " + reader.GetString (6) + "\n";

					} else {

						textview2.Buffer.Text = "Sorry ! Staff Member not found.";
					}
					cmd.Dispose ();
					cmd = null;
					if (conn != null)
						conn.Close ();
					if (reader != null)
						reader.Close ();
		    

				} catch (Exception ex) {
					textview2.Buffer.Text = ex.Message;

				}
			} else {
				textview2.Buffer.Text = " First enter the NAME or ID !";
			}
	
		}		

		protected void OnButton3Clicked (object sender, EventArgs e)
		{
			this.Destroy();
		}	

		protected void OnButton2Clicked (object sender, EventArgs e)
		{
			if (!(entry3.Text.Equals(""))) {
				entry7.Text = "";
				string cs = "Server=localhost;" + "Database=hospital;" + "User ID=root;" + "Password=rahul008;" + "Pooling=false";
				MySqlConnection conn;
				MySqlDataReader reader;
				string s = "";
				int count = 0;
				try {
					conn = new MySqlConnection (cs);
					conn.Open ();
					string str = "SELECT * FROM hospital.staff where name = '" + entry3.Text + "';";
					MySqlCommand cmd = new MySqlCommand (str, conn);
					reader = cmd.ExecuteReader ();
					if (reader.HasRows) {
						while (reader.Read()) {
							s = s + "Staff Member Details\n\n" + 
								"UId:  " + reader.GetString (0) + " \n" +
								"Name:  " + reader.GetString (1) + "\n" +
								"Department: " + reader.GetString (2) + "\n" +
								"Staff Category: " + reader.GetString (3) + " \n " +
								"Age: " + reader.GetString (5) + "\n" +
								"Gender: " + reader.GetString (6) + "\n";
							count++;
						}
						textview2.Buffer.Text = "  '" + count + "' results found!\n\n";
						textview2.Buffer.Text = textview2.Buffer.Text + s;

					} else {

						textview2.Buffer.Text = "Sorry ! Staff Member not found.";
					}
					cmd.Dispose ();
					cmd = null;
					if (conn != null)
						conn.Close ();
					if (reader != null)
						reader.Close ();
		    

				} catch (Exception ex) {
					textview2.Buffer.Text = ex.Message;

				}
	
			} else {

				textview2.Buffer.Text = "First Enter the Name or ID ! ";
			}

		}



	}
}

