using System;
using System.IO;
using Gtk;
using hm;
using System.Data;
using MySql.Data.MySqlClient;

namespace hm
{
	public partial class billgenerate : Gtk.Window
	{
		public billgenerate () : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}		
		private string id,report;
		protected void OnButton6Clicked (object sender, EventArgs e)
		{
			if (!(entry1.Text.Equals(""))) {
				string cs = "Server=localhost;" + "Database=hospital;" + "User ID=root;" + "Password=rahul008;" + "Pooling=false";
				MySqlConnection conn, conn1;
				MySqlDataReader reader, reader1;

				try {
					conn = new MySqlConnection (cs);
					conn1 = new MySqlConnection (cs);
					conn.Open ();
					conn1.Open ();
					string str = "SELECT * FROM hospital.patient where RegisId = " + entry1.Text + ";";
					string str1 = "SELECT * FROM hospital.bill where billid = " + entry1.Text + ";";
					MySqlCommand cmd = new MySqlCommand (str, conn);
					MySqlCommand cmd1 = new MySqlCommand (str1, conn1); 
					reader = cmd.ExecuteReader ();
					reader1 = cmd1.ExecuteReader ();

					if (reader.Read () && reader1.Read ()) {
						id = reader.GetString (0);
						report = "FORTIS,New Delhi\n\n***********PATIENT DETAILS*************\n\n" + 
							"Registration ID:  " + id + " \n" +
							"Name:  " + reader.GetString (1) + "\n" +
							"Age: " + reader.GetString (2) + "\n" +
							"Gender: " + reader.GetString (3) + "\n" +
							"Registration Date and Time: " + reader.GetString (4) + "\n" +
							"Mobile No: " + reader.GetString (6) + "\n\n\n" +
							"***********BILL***********\n\n " +
							"Registration Fee : " + reader1.GetUInt16 (1) + "\n" + 
							"Lab Fee : " + reader1.GetUInt16 (2) + "\n" +
							"Medicine Charge : " + reader1.GetUInt16 (3) + "\n" +
							"Room Charge : " + reader1.GetUInt16 (4) + "\n" +
							"Treatment Fee : " + reader1.GetUInt16 (5) + "\n" + 
							"Total bill in INR : " + reader1.GetUInt16 (6) + "\n"; 

						textview2.Buffer.Text = report;


					} else {

						textview2.Buffer.Text = "Sorry ! Patient not found.";
					}
					cmd.Dispose ();
					cmd = null;
					if (conn != null)
						conn.Close ();
					if (conn1 != null)
						conn1.Close ();
					if (reader != null)
						reader.Close ();
		    

				} catch (Exception ex) {
					textview2.Buffer.Text = ex.Message;

				}
			} else {
				textview2.Buffer.Text = "Please First enter the Registration Number!";
			}
		}	

		protected void OnButton5Clicked (object sender, EventArgs e)
		{
			this.Destroy();
		}

		protected void OnButton4Clicked (object sender, EventArgs e)
		{
			if (!(entry1.Text.Equals(""))) {
				try {
					StreamWriter sw = new StreamWriter (id);
					sw.Write (report);
					sw.Close ();
					textview2.Buffer.Text = "Report generated successfull! ";
				} catch (Exception ex) {
					textview2.Buffer.Text = ex.Message;
				}
			} else {
				textview2.Buffer.Text = "Please First enter the Registration Number!";
			}
		}



	}
}

