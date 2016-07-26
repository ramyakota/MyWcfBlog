using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using WebApplicationNew.UserProfileService;
//using System.Configuration;

namespace WebApplicationNew
{
	public partial class UserInfoPage : System.Web.UI.Page
	{
		
		public void DisplayFields()
		{
			try
			{
				//
				UserProfileServiceClient client = new UserProfileServiceClient("BasicHttpBinding_IUserProfileService");
				UserInfoDataModel.UserInfoDataModel res = client.GetUserProfileDetails("123");
				txtfirstname.Text = res.FirstName;//(dr["firstname"].ToString());

				//
				string cs = ConfigurationManager.ConnectionStrings["users"].ConnectionString;
				SqlConnection conn = new SqlConnection(cs);
				SqlCommand cmd = new SqlCommand("select userid,firstname,lastname,email,addr1,addr2,street,city,state,zipcode,mobilenumber from usersinfo", conn);
			conn.Open();
			SqlDataReader dr = cmd.ExecuteReader();
			while (dr.Read())
			{
				txtuserid.Text = (dr["userid"].ToString());
					txtfirstname.Text = res.FirstName;//(dr["firstname"].ToString());
				txtlastname.Text = (dr["lastname"].ToString());
				txtemail.Text = (dr["email"].ToString());
				//dropdownmonth.Text = (dr["userid"].ToString());
				//dropdownday.Text = (dr["userid"].ToString());
				//dropdownyear.Text = (dr["userid"].ToString());
				//txtgender.SelectedItem.Text = (dr["gender"].ToString());
				txtaddr1.Text = (dr["addr1"].ToString());
				txtaddr2.Text = (dr["addr2"].ToString());
				txtstreet.Text = (dr["street"].ToString());
				txtcity.Text = (dr["city"].ToString());
				txtstate.Text = (dr["state"].ToString());
				txtzip.Text = (dr["zipcode"].ToString());
				txtmobile.Text = (dr["mobilenumber"].ToString());
			}
			conn.Close();
		}
		catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
}
	protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				DisplayFields();
			}
		}

		protected void btnedit_Click(object sender, EventArgs e)
		{
			string userid = txtuserid.Text;
			string firstname = txtfirstname.Text;
			string lastname = txtlastname.Text;
			string email = txtemail.Text;
			//string birthday = Convert.ToString(dt2);
			//string gender = txtgender.Text;
			string addr1 = txtaddr1.Text;
			string addr2 = txtaddr2.Text;
			string street = txtstreet.Text;
			string city = txtcity.Text;
			string state = txtstate.Text;
			string zip = txtzip.Text;
			string mobile = txtmobile.Text;

			UserProfileServiceClient client = new UserProfileServiceClient("BasicHttpBinding_IUserProfileService");
			bool res = client.Edit(userid, firstname, lastname, email,
			 addr1, addr2, street, city, state, zip, mobile);
			if (res == true)
			{
				Response.Redirect("MainPage.aspx");
			}
		}
	}
}