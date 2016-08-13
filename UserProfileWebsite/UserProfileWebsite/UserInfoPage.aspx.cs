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

				if (Session["UserInfoDataModel"] != null)
				{
					UserInfoDataModel.UserInfoDataModel res = Session["UserInfoDataModel"] as UserInfoDataModel.UserInfoDataModel;
					txtuserid.Text = res.userid;
					//txtfirstname.Text = res.FirstName;//(dr["firstname"].ToString());
					//txtuserid.Text = res.userid;
					txtfirstname.Text = res.FirstName;
					txtlastname.Text = res.LastName;
					txtemail.Text = res.email;
					//dropdownmonth.Text = (dr["userid"].ToString());
					//dropdownday.Text = (dr["userid"].ToString());
					//dropdownyear.Text = (dr["userid"].ToString());
					//txtgender.SelectedItem.Text = (dr["gender"].ToString());
					txtaddr1.Text = res.addr1;
					txtaddr2.Text = res.addr2;
					txtstreet.Text = res.street;
					txtcity.Text = res.city;
					txtstate.Text = res.state;
					txtzip.Text = res.zipcode;
					txtmobile.Text = res.mobilenumber;
				}
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
			UserInfoDataModel.UserInfoDataModel data = new UserInfoDataModel.UserInfoDataModel();
			data.userid = txtuserid.Text;
			data.FirstName = txtfirstname.Text;
			data.LastName = txtlastname.Text;
			data.email = txtemail.Text;
			//string birthday = Convert.ToString(dt2);
			//string gender = txtgender.Text;
			data.addr1 = txtaddr1.Text;
			data.addr2 = txtaddr2.Text;
			data.street = txtstreet.Text;
			data.city = txtcity.Text;
			data.state = txtstate.Text;
			data.zipcode = txtzip.Text;
			data.mobilenumber = txtmobile.Text;

			UserProfileServiceClient client = new UserProfileServiceClient("BasicHttpBinding_IUserProfileService");
			
			bool res = client.Edit(data);
			if (res == true)
			{
				Response.Redirect("MainPage.aspx");
			}
		}
	}
}