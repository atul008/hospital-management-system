using System;
using Gtk;
using hm;
using System.Data;
using MySql.Data.MySqlClient;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}


	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
	protected void OnButton1Clicked (object sender, EventArgs e)
	{
		
		string cs= "Server=localhost;" + "Database=hospital;" + "User ID=root;" + "Password=rahul008;" + "Pooling=false";
		MySqlConnection conn;
		MySqlDataReader reader;
		try {
			conn = new MySqlConnection (cs);
			conn.Open ();
       		string str = "SELECT * FROM hospital.login where uname = '"+entry1.Text+"' and pwd ='"+ entry2.Text +"';";
			MySqlCommand cmd = new MySqlCommand(str,conn);
			reader = cmd.ExecuteReader();
			if(reader.HasRows){
			
				textview1.Buffer.Text = "Login sucessfull !";
				home h = new home ();
				h.Show ();
				this.Destroy ();

			}else{

				textview1.Buffer.Text = "Login unsucessfull !";
				entry2.Text = "";
			}
	       cmd.Dispose();
	       cmd = null;
			if(conn != null)
				conn.Close();
			if(reader !=null)
				reader.Close();
		    

		} catch (Exception ex) {
			textview1.Buffer.Text = ex.Message;

		}
	}	
	protected void OnButton5Clicked (object sender, EventArgs e)
	{
		textview1.Buffer.Text = "What is this ? \n" +
								"This is a tool to manage to a hospital's data about its patients and staff.\n "+
								"we can search for or register a patient.We can search a staff member.\n" +
								"This software is equiped with user authentication.\n\n"+
								"                                 ---------- By Atul Kumar (H.B.T.I KANPUR)";
	}


}
