using System;
using Gtk;
using hm;
using System.Data;
using MySql.Data.MySqlClient;

namespace hm
{
	public partial class searchPatient : Gtk.Window
	{
		public searchPatient () : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}
		protected void OnButton10Clicked (object sender, EventArgs e)
		{
			if (!(entry6.Text.Equals(""))) {
				entry2.Text = "";
				string cs = "Server=localhost;" + "Database=hospital;" + "User ID=root;" + "Password=rahul008;" + "Pooling=false";
				MySqlConnection conn;
				MySqlDataReader reader;
				try {
					conn = new MySqlConnection (cs);
					conn.Open ();
					string str = "SELECT * FROM hospital.patient where RegisId = " + entry6.Text + ";";
					MySqlCommand cmd = new MySqlCommand (str, conn);
					reader = cmd.ExecuteReader ();
					if (reader.Read ()) {
			
						textview1.Buffer.Text = "Patient Details\n\n" + 
							"Registration ID:  " + reader.GetString (0) + " \n" +
							"Name:  " + reader.GetString (1) + "\n" +
							"Age: " + reader.GetString (2) + "\n" +
							"Gender: " + reader.GetString (3) + "\n" +
							"Registration Date and Time: " + reader.GetString (4) + "\n" +
							"Mobile No: " + reader.GetString (6) + "\n" +
							"Health Issue: " + reader.GetString (7) + "\n";
						;

					} else {

						textview1.Buffer.Text = "Sorry ! Patient not found.";
					}
					cmd.Dispose ();
					cmd = null;
					if (conn != null)
						conn.Close ();
					if (reader != null)
						reader.Close ();
		    

				} catch (Exception ex) {
					textview1.Buffer.Text = ex.Message;

				}
			} else {
				textview1.Buffer.Text = "First enter the NAME or Registration ID !";
			}
		}		
		protected void OnButton4Clicked (object sender, EventArgs e)
		{
			this.Destroy();
		}	

		protected void OnButton11Clicked (object sender, EventArgs e)
		{
			if (!(entry2.Text.Equals(""))) {
				entry6.Text = "";

				string cs = "Server=localhost;" + "Database=hospital;" + "User ID=root;" + "Password=rahul008;" + "Pooling=false";
				MySqlConnection conn;
				MySqlDataReader reader;
				string s = "";
				int count = 0;
				try {
					conn = new MySqlConnection (cs);
					conn.Open ();
					string str = "SELECT * FROM hospital.patient where name = '" + entry2.Text + "';";
					MySqlCommand cmd = new MySqlCommand (str, conn);
					reader = cmd.ExecuteReader ();
					if (reader.HasRows) {
						while (reader.Read()) {
			
							s = s + "Patient Details\n\n" + 
								"Registration ID:  " + reader.GetString (0) + " \n" +
								"Name:  " + reader.GetString (1) + "\n" +
								"Age: " + reader.GetString (2) + "\n" +
								"Gender: " + reader.GetString (3) + "\n" +
								"Registration Date and Time: " + reader.GetString (4) + "\n" +
								"Mobile No: " + reader.GetString (6) + "\n" +
								"Health Issue: " + reader.GetString (7) + "\n";
							count++;
						}
						textview1.Buffer.Text = "   " + count + " results found! \n\n";
						textview1.Buffer.Text = textview1.Buffer.Text + s; 

					} else {

						textview1.Buffer.Text = "Sorry ! Patient not found.";
					}
					cmd.Dispose ();
					cmd = null;
					if (conn != null)
						conn.Close ();
					if (reader != null)
						reader.Close ();
		    

				} catch (Exception ex) {
					textview1.Buffer.Text = ex.Message;

				}
	
			} else {
				textview1.Buffer.Text = "First enter the NAME or Registration ID !";
			}
		}



	}
}

