using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplicationNew.UserProfileService;

namespace WebApplicationNew
{
	public partial class SignUpPage : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (Session["Name"] != null)
			{
				txtfirstname.Text = Session["First Name"].ToString();
			}
			if (Session["Name"] != null)
			{
				txtemail.Text = Session["Email"].ToString();
			}
		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			UserProfileDataModel.UserProfileDataModel userprofiledata = new UserProfileDataModel.UserProfileDataModel();
			string dateTime = "01/08/2008 14:50:50.42";
			IFormatProvider culture = new System.Globalization.CultureInfo("fr-FR", true);
			DateTime dt2 = DateTime.Parse(dateTime, culture, System.Globalization.DateTimeStyles.AssumeLocal);
			Console.WriteLine(" Month: {0}, Day: {1},Year: {2}, Hour: {3}, Minute: {4}, Second: {5}, Millisecond: {6}",
							  dt2.Year, dt2.Month, dt2.Day, dt2.Hour, dt2.Minute, dt2.Second, dt2.Millisecond);
			userprofiledata.userid = txtuserid.Text;
			userprofiledata.firstname = txtfirstname.Text;
			userprofiledata.lastname = txtlastname.Text;
			userprofiledata.email = txtemail.Text;
			userprofiledata.birthday = Convert.ToString(dt2);
			userprofiledata.gender = txtgender.Text;
			userprofiledata.addr1 = txtaddr1.Text;
			userprofiledata.addr2 = txtaddr2.Text;
			userprofiledata.street = txtstreet.Text;
			userprofiledata.city = txtcity.Text;
			userprofiledata.state = txtstate.Text;
			userprofiledata.zipcode = txtzip.Text;
			userprofiledata.mobilenumber = txtmobile.Text;
			userprofiledata.password = txtpassword.Text;
			UserProfileServiceClient client = new UserProfileServiceClient("BasicHttpBinding_IUserProfileService");
			bool res = client.SignUp(userprofiledata);
			
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