using System;
using Gtk;
using hm;
using System.Data;
using MySql.Data.MySqlClient;

namespace hm
{
	public partial class AddMember : Gtk.Window
	{
		public AddMember () : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}
		private string id = null;
		private string dept = null;
		private string name = null;
		private string age  = null;
		private string sex  = null;
		private string type = null;
		private string speciality = null;
		private	string cs = "Server=localhost;"+"Database=hospital;"+"User ID=root;"+"Password=rahul008;" +"Pooling=false";	
		protected void OnButton3Clicked (object sender, EventArgs e)
		{
			comboboxentry1.Active = 0;
			entry4.Text = "";
			entry5.Text = "";
			entry6.Text = "";
			entry7.Text = "";
			textview3.Buffer.Text = "";

		
		}		
		MySqlConnection conn ;
		protected void OnButton4Clicked (object sender, EventArgs e)
		{
		
			dept = comboboxentry1.ActiveText;	
			id = entry4.Text;
			name = entry5.Text;
			age = entry6.Text;
			speciality = entry7.Text;

			if (radiobutton1.Active) {
				sex = "male";
			} else {
				sex = "female";
			}

			if (radiobutton3.Active) {
				type = "doctor";
			} else if (radiobutton4.Active) {
				type = "para-medical";
			} else {
				type = "non-medical";
			}

		//	Console.WriteLine (dept + " " + name + " " + age + " " + sex + " " + mobile);

			try {
				conn = new MySqlConnection (cs);

				conn.Open ();
				MySqlCommand cmd = new MySqlCommand ();
				cmd.Connection = conn;
				cmd.CommandText = "INSERT INTO hospital.staff ( uid,name,dept,type,speciality,age,sex) VALUES (" + id +
					",'" + name + "','" + dept + "','" + type + "','" + speciality + "','"+ age +"','"+sex +"');";



				//		Console.WriteLine(cmd.CommandText);	
				if (id.Equals("") || dept.Equals ("") || name.Equals ("") || age.Equals ("") || speciality.Equals ("")) {

					textview3.Buffer.Text = "Please fill all entries in the form !";

				} else {
					try {
						Convert.ToInt64 (entry6.Text);
						Convert.ToInt64 (entry4.Text);
						cmd.Prepare ();
					cmd.ExecuteNonQuery ();
					textview3.Buffer.Text = "Registration sucessfull !\n "+"Member Details\n\n"+ 
										"Unique ID:  " + id + " \n" +
										"Name:  " + name + "\n" +
										"Age: " +age +"\n"+
										"Gender: " +sex +"\n"+
										"Type: " + type +"\n"+
										"Department: " + dept+"\n"+
										"Speciality :" +speciality + "\n";
					
					} catch {
						textview3.Buffer.Text = "'Id' and 'Age' should be Number!";
					}
			}
			}catch (Exception ex) {

				textview3.Buffer.Text = ex.Message;
			} finally {
				if(conn != null)
					conn.Close();

			}
		
		}		
		protected void OnButton5Clicked (object sender, EventArgs e)
		{
			this.Destroy();
		}
	}
}

