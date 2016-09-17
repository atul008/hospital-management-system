using System;
using System.Data;
using MySql.Data.MySqlClient;
using Gtk;
namespace hm
{
	public partial class PatientInfo : Gtk.Window
	{
		public PatientInfo () : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}		
		private string dept = null;
		private string name = null;
		private string age  = null;
		private string sex  = null;
		private string mobile = null;
		private string health = null;
			
		private	string cs = "Server=localhost;"+"Database=hospital;"+"User ID=root;"+"Password=rahul008;" +"Pooling=false";

		MySqlConnection conn ;
		MySqlDataReader reader ;
		MySqlCommand cmd ,cm1,cmd2;

		protected void OnButton2Clicked (object sender, EventArgs e)
		{

			dept = comboboxentry2.ActiveText;	
			name = entry2.Text;
			age = entry3.Text;
			if (radiobutton3.Active) {
				sex = "male";
			} else {
				sex = "female";
			}
			mobile = entry7.Text;
			health = entry1.Text;
		//	Console.WriteLine (dept + " " + name + " " + age + " " + sex + " " + mobile);

			try {
				conn = new MySqlConnection (cs);

				conn.Open ();
				 cmd = new MySqlCommand ();
				string str = "SELECT * FROM hospital.patient where mobile = "+ mobile +";";
				 cm1 = new MySqlCommand(str,conn);
				 cmd2 = new MySqlCommand();
				cmd.Connection = conn;
				cmd2.Connection = conn;
				cmd.CommandText = "INSERT INTO hospital.patient ( name,age,sex,indate,mobile,healthProblem ) VALUES ('" + name +
					"','" + age + "','" + sex + "','" + System.DateTime.Today + "','" + mobile + "','"+health+"' );";



				//		Console.WriteLine(cmd.CommandText);	
				if (dept.Equals ("") || name.Equals ("") || age.Equals ("") || mobile.Equals ("")) {

					textview3.Buffer.Text = "Please fill all entries in the form !";

				} else {

					try{

							Convert.ToInt64(entry3.Text);
							Convert.ToInt64(entry7.Text);
							
							cmd.Prepare ();
							cmd.ExecuteNonQuery ();
							reader = cm1.ExecuteReader();

							if(reader.Read()){
								int a = reader.GetInt16(0);
							textview3.Buffer.Text = "Registration sucessfull !\n "+"Patient Details\n\n"+ 
												"Registration ID:  " + a + " \n" +
												"Name:  " + name + "\n" +
												"Age: " +age +"\n"+
												"Gender: " +sex +"\n"+
												"Registration Date and Time: " + reader.GetString(4)+"\n"+
												"Mobile No: " +mobile +"\n"+
												"Health Issue: " + health +"\n";
							textview2.Buffer.Text = ""+ a;
							conn.Close();
							conn.Open();
					
							cmd2.CommandText = "INSERT INTO hospital.bill (billid, registrationFee, labFee,"+
									" medicineCharge, roomcharge, doctorFee,otherCharges,total) VALUES ("+ a
									+", 500, 0, 0, 0, 0,0,500);";
							cmd2.Prepare();
							cmd2.ExecuteNonQuery();

							} else{
								textview3.Buffer.Text = "Sorry ! Patient not found. ";
							}
					
					}catch{
							 
						//textview3.Buffer.Text = ex.Message;
							textview3.Buffer.Text = "Age and Phone Number should be in digits!";

					}
				}
		} catch (Exception ex) {

				textview3.Buffer.Text = ex.Message;
		} finally {
			if(conn != null)
				conn.Close();

				cm1.Dispose();
				cmd.Dispose();
				cmd2.Dispose ();
			

		}
		
	}	


		protected void OnButton1Clicked (object sender, EventArgs e)
		{
			comboboxentry2.Active = 0;
			entry2.Text ="";
			entry3.Text = "";
			entry7.Text = "";
			entry1.Text = "";
			textview2.Buffer.Text = "";
			textview3.Buffer.Text = "Form reseted!";
		}		

		protected void OnButton3Clicked (object sender, EventArgs e)
		{
			this.Destroy();
		}

	}
}

