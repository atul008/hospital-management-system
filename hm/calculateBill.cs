using System;
using Gtk;
using hm;
using System.Data;
using MySql.Data.MySqlClient;

namespace hm
{
	public partial class calculateBill : Gtk.Window
	{
		public calculateBill () : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}
		private int billid  = 0 ;
		private int regf = 0;
		private int labf = 0;
		private int medf = 0;
		private int roomf = 0;
		private int docf = 0;
		private int otherf = 0;
		private int totalf = 0;
		private int prevtotalf = 0;
		private int currtotalf = 0;
		private int flag = 0;

		protected void OnButton2Clicked (object sender, EventArgs e)
		{
		
		string cs= "Server=localhost;" + "Database=hospital;" + "User ID=root;" + "Password=rahul008;" + "Pooling=false";
		MySqlConnection conn,conn1;
		MySqlDataReader reader,reader1;
		try {
			conn = new MySqlConnection (cs);
			conn1 = new MySqlConnection (cs);
			conn.Open ();
			conn1.Open();
       		string str = "SELECT * FROM hospital.patient where RegisId = "+ entry7.Text +";";
			string str1 = "SELECT * FROM hospital.bill where billid = "+entry7.Text +";";
			MySqlCommand cmd = new MySqlCommand(str,conn);
			MySqlCommand cmd1 = new MySqlCommand(str1,conn1);

			billid = Convert.ToInt32( entry7.Text);

			reader = cmd.ExecuteReader();
			reader1 = cmd1.ExecuteReader();

			if(reader.Read()){

					label12.Text = "Patient Found";
					label9.Text =":  " + reader.GetString(1);
			//		Console.WriteLine(reader.GetString(1));
					if(reader1.Read()){
						regf = reader1.GetInt16(1);
						Console.WriteLine(reader1.GetInt16(1));
						labf = reader1.GetInt16(2);
						medf = reader1.GetInt16(3);
						roomf = reader1.GetInt16(4);
						docf = reader1.GetInt16(5);
						otherf = reader1.GetInt16(6);
						prevtotalf = Convert.ToInt32(reader1.GetString(7));
					}


			}else{
					label12.Text = "No such Patient";
					flag = 1;
			}
	       cmd.Dispose();
	       cmd = null;
			if(conn != null)
				conn.Close();
			if(reader !=null)
				reader.Close();
		    

		} catch (Exception ex) {
			label9.Text = ex.Message;
		}
		}

		protected void OnButton6Clicked (object sender, EventArgs e)
		{
			if (!entry7.Text.Equals ("")) {
				if (entry1.Text.Equals ("") || entry2.Text.Equals ("") || entry3.Text.Equals ("") || entry4.Text.Equals ("") || entry5.Text.Equals ("") || entry6.Text.Equals ("")) {

					textview4.Buffer.Text = "Please fill all entries in the form !";

				} else {
					try {
						currtotalf = Convert.ToInt32 (entry1.Text) +
							Convert.ToInt32 (entry2.Text) +
							Convert.ToInt32 (entry3.Text) +
							Convert.ToInt32 (entry4.Text) +
							Convert.ToInt32 (entry5.Text) +
							Convert.ToInt32 (entry6.Text);

						regf += Convert.ToInt32 (entry1.Text);
						labf += Convert.ToInt32 (entry2.Text);
						medf += Convert.ToInt32 (entry3.Text);
						roomf += Convert.ToInt32 (entry4.Text);
						docf += Convert.ToInt32 (entry5.Text);
						otherf += Convert.ToInt32 (entry6.Text);
						totalf = regf + labf + medf + roomf + docf + otherf;
						textview4.Buffer.Text = "" + currtotalf;

					} catch {
						textview4.Buffer.Text = "All entries should be in digits ";
					}


				}
			} else {
				textview4.Buffer.Text = "First Enter Patient's Registration Number";
			}

		}		

		protected void OnButton7Clicked (object sender, EventArgs e)
		{

			string cs = "Server=localhost;" + "Database=hospital;" + "User ID=root;" + "Password=rahul008;" + "Pooling=false";
			MySqlConnection conn = new MySqlConnection (cs);

			if (flag == 0) {
				if (!entry7.Text.Equals ("")) {

					if (entry1.Text.Equals ("") || entry2.Text.Equals ("") || entry3.Text.Equals ("") || entry4.Text.Equals ("") || entry5.Text.Equals ("") || entry6.Text.Equals ("")) {

						textview4.Buffer.Text = "Please fill all entries in the form !";

					} else {

						try {

							conn.Open ();
							MySqlCommand cmd = new MySqlCommand ();
							cmd.Connection = conn;
							cmd.CommandText = "UPDATE hospital.bill SET registrationFee=" + regf + ", labFee=" + labf + ", medicineCharge=" + medf + ", " +
								"roomcharge=" + roomf + ", doctorFee=" + docf + ", otherCharges=" + otherf + " ,total= '" + totalf + "' WHERE billid=" + billid + ";";

							
							cmd.Prepare ();
							cmd.ExecuteNonQuery ();
							textview5.Buffer.Text = "Bill updation  sucessfull !\n " + "Bill Details\n\n" +
								"Total Bill before updation: " + prevtotalf + "\n\n" +
								"Total Reigistration Fee:  " + regf + " \n" +
								"Total  Lab Charge:" + labf + "\n" +
								"Total Medicine Charge: " + medf + "\n" +
								"Total Room charge: " + roomf + "\n" +
								"Total Doctor Fee" + docf + "\n" +
								"Total other charges: " + otherf + "\n\n" +
								"Grand Total :" + totalf + "\n";

					

						} catch (Exception ex) {

							textview5.Buffer.Text = ex.Message;

						} finally {

							if (conn != null)
								conn.Close ();

						}
				
					} 
				} else {
					textview5.Buffer.Text = "First Enter Patient's Registration Number";
				}

			} else{
					textview5.Buffer.Text = "Update Can't be done ! Since no such Patient!!";
			}


		}
			protected void OnButton4Clicked (object sender, EventArgs e)
		{
			this.Destroy();
		}



		protected void OnButton5Clicked (object sender, EventArgs e)
		{
			regf = 0;
			medf = 0;
			roomf = 0;
			docf = 0;
			labf = 0;
			flag =0;
			prevtotalf = 0;
			currtotalf = 0 ;
			totalf = 0;
			entry1.Text = "";
			entry2.Text = "";
			entry3.Text = "";
			entry4.Text = "";
			entry5.Text = "";
			entry6.Text = "";
			entry7.Text = "";
			label9.Text = "";
			textview4.Buffer.Text = "";
			textview5.Buffer.Text = "";

		}






	}
}

