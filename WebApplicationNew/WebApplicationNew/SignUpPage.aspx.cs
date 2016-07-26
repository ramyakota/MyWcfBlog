using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationNew
{
	public partial class SignUpPage : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			string dateTime = "01/08/2008 14:50:50.42";
			IFormatProvider culture = new System.Globalization.CultureInfo("fr-FR", true);
			DateTime dt2 = DateTime.Parse(dateTime, culture, System.Globalization.DateTimeStyles.AssumeLocal);
			Console.WriteLine(" Month: {0}, Day: {1},Year: {2}, Hour: {3}, Minute: {4}, Second: {5}, Millisecond: {6}",
							  dt2.Year, dt2.Month, dt2.Day, dt2.Hour, dt2.Minute, dt2.Second, dt2.Millisecond);
			string userid = txtuserid.Text;
			string firstname = txtfirstname.Text;
			string lastname = txtlastname.Text;
			string email = txtemail.Text;
			string birthday = Convert.ToString(dt2);
			string gender = txtgender.Text;
			string addr1 = txtaddr1.Text;
			string addr2 = txtaddr2.Text;
			string street = txtstreet.Text;
			string city = txtcity.Text;
			string state = txtstate.Text;
			string zip = txtzip.Text;
			string mobile = txtmobile.Text;
			string password = txtpassword.Text;
			SignUpWcf.SignUpWcfClient client = new SignUpWcf.SignUpWcfClient("BasicHttpBinding_ISignUpWcf");
			bool res = client.SignUp(userid,  firstname,  lastname,  email, birthday,  gender,
			 addr1,  addr2,  street,  city,  state,  zip,  mobile,  password);
			
			txtfirstname.Text = "";
			txtlastname.Text = "";
			txtemail.Text = "";
			txtaddr1.Text = "";
			txtaddr2.Text = "";
			txtstreet.Text = "";
			txtcity.Text = "";
			txtzip.Text = "";
			txtmobile.Text = "";
			txtuserid.Text = "";
			txtpassword.Text = "";
			txtrepassword.Text = "";
			txtreemail.Text = "";
			dropdownmonth.Text = "";
			dropdownday.Text = "";
			dropdownyear.Text = "";
			txtfirstname.Focus();
			if (res == true)
			{
				Response.Redirect("MainPage.aspx");
			}
		}
	}
}