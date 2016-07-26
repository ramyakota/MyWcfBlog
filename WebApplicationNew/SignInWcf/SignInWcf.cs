using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace SignInWcf
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SignIn" in both code and config file together.
	public class SignInWcf : ISignInWcf
	{
		public bool SignIn(string userid, string password)
		{
			//string cs = ConfigurationManager.ConnectionStrings["users"].ConnectionString;
			string cs = @"server=Sweetu\SQLEXPRESS;database=mynewproject;Trusted_Connection=True;";
			SqlConnection conn = new SqlConnection(cs);
			SqlCommand cmd = new SqlCommand("Select count(*) from usersinfo where userid=@userid and password=@password", conn);
			cmd.Parameters.AddWithValue("@userid", userid);
			cmd.Parameters.AddWithValue("@password", password);
			conn.Open();
			object i = cmd.ExecuteScalar();
			conn.Close();
			if (Convert.ToInt16(i) > 0)
			{
				return true;
				//Response.Redirect("UserInfoPage.aspx");
			}
			else
			{
				return false;
			}

		}

		public void SignUp(string firstname, string email)
		{

		}
	}
}
