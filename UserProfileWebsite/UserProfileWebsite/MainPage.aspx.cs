using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplicationNew.UserProfileService;

namespace WebApplicationNew
{
	public partial class MainPage : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void btnSignIn_Click(object sender, EventArgs e)
		{
			string userid = txtUn.Text;
			string password = txtPwd.Text;
			UserProfileServiceClient client = new UserProfileServiceClient("BasicHttpBinding_IUserProfileService");
			UserInfoDataModel.UserInfoDataModel result = client.GetUserProfileDetails(userid, password);
		//	bool res = client.SignIn(userid,password);
			Session["UserInfoDataModel"] = result;
			if (result!=null && !string.IsNullOrEmpty(result.userid))
			{
				Response.Redirect("UserInfoPage.aspx");
			}
		}

		protected void btnSignUp_Click(object sender, EventArgs e)
		{
			Session["First Name"] = txtFName.Text;
			Session["Email"] = txtEmail.Text;
			Response.Redirect("SignUpPage.aspx");
		}

		protected void LinkButton1_Click(object sender, EventArgs e)
		{
			Response.Redirect("ForgotPassword.aspx");
		}
	}
}