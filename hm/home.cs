using System;
using Gtk;
using hm;
using System.Data;
using MySql.Data.MySqlClient;

namespace hm
{
	public partial class home : Gtk.Window
	{
		public home () : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}
		protected void OnDeleteEvent (object sender, DeleteEventArgs a)
		{
			Application.Quit ();
			a.RetVal = true;
		}
			protected void OnButton3Clicked (object sender, EventArgs e)
		{
		PatientInfo	pi = new PatientInfo();
				pi.Show();
			//throw new System.NotImplementedException ();
		}		protected void OnButton4Clicked (object sender, EventArgs e)
		{
			searchPatient sp = new searchPatient();
			sp.Show();

		}		protected void OnButton6Clicked (object sender, EventArgs e)
		{
			seachStaff sf = new seachStaff();
			sf.Show ();

		}		
		protected void OnButton1Clicked (object sender, EventArgs e)
		{
			MainWindow win = new MainWindow();
			win.Show();
			this.Destroy();

		}
		protected void OnButton2Clicked (object sender, EventArgs e)
		{
			this.Destroy();
		}		
		protected void OnButton5Clicked (object sender, EventArgs e)
		{
			billgenerate bill = new billgenerate();
			bill.Show();
		}		

		protected void OnButton7Clicked (object sender, EventArgs e)
		{
			AddMember mem = new AddMember();
			mem.Show();
		}		
		protected void OnButton8Clicked (object sender, EventArgs e)
		{
			calculateBill bill = new calculateBill();
			bill.Show ();
		}




	}
}

