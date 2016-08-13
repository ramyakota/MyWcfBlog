using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using UserInfoDataModel;

namespace UserProfileService
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "UserProfileService" in both code and config file together.
	public class UserProfileService : IUserProfileService
	{
		public bool SignUp(UserProfileDataModel.UserProfileDataModel userProfileDataModel)
		{

			string dateTime = "01/08/2008 14:50:50.42";
			IFormatProvider culture = new System.Globalization.CultureInfo("fr-FR", true);
			DateTime dt2 = DateTime.Parse(dateTime, culture, System.Globalization.DateTimeStyles.AssumeLocal);
			Console.WriteLine(" Month: {0}, Day: {1},Year: {2}, Hour: {3}, Minute: {4}, Second: {5}, Millisecond: {6}",
							  dt2.Year, dt2.Month, dt2.Day, dt2.Hour, dt2.Minute, dt2.Second, dt2.Millisecond);
			userProfileDataModel.birthday = Convert.ToString(dt2);
			//DateTime dt = new DateTime(Convert.ToInt32(dropdownmonth.Text), Convert.ToInt32(dropdownday.Text), Convert.ToInt32(dropdownyear.Text));
			//string cs = ConfigurationManager.ConnectionStrings["users"].ConnectionString;
			string cs = @"server=Sweetu\SQLEXPRESS;database=mynewproject;Trusted_Connection=True;";
				SqlConnection conn = new SqlConnection(cs);
				SqlCommand cmd = new SqlCommand("insert into usersinfo values(@userid,@firstname,@lastname,@email,@birthday,@gender,@addr1,@addr2,@street,@city,@state,@zipcode,@mobilenumber,@password)", conn);
				cmd.Parameters.AddWithValue("@userid", userProfileDataModel.userid);
				cmd.Parameters.AddWithValue("@firstname", userProfileDataModel.firstname);
				cmd.Parameters.AddWithValue("@lastname", userProfileDataModel.lastname);
				cmd.Parameters.AddWithValue("@email", userProfileDataModel.email);
				cmd.Parameters.AddWithValue("@birthday", userProfileDataModel.birthday);
				cmd.Parameters.AddWithValue("@gender", userProfileDataModel.gender);
				cmd.Parameters.AddWithValue("@addr1", userProfileDataModel.addr1);
				cmd.Parameters.AddWithValue("@addr2", userProfileDataModel.addr2);
				cmd.Parameters.AddWithValue("@street", userProfileDataModel.street);
				cmd.Parameters.AddWithValue("@city", userProfileDataModel.city);
				cmd.Parameters.AddWithValue("@state", userProfileDataModel.state);
				cmd.Parameters.AddWithValue("@zipcode", userProfileDataModel.zipcode);
				cmd.Parameters.AddWithValue("@mobilenumber", userProfileDataModel.mobilenumber);
				cmd.Parameters.AddWithValue("@password", userProfileDataModel.password);
				conn.Open();
				object i = cmd.ExecuteNonQuery();
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
				//return firstname;
			}

		public bool Edit(UserInfoDataModel.UserInfoDataModel userdatamodel)
		{
			try
			{

				string cs = @"server=Sweetu\SQLEXPRESS;database=mynewproject;Trusted_Connection=True;";
				SqlConnection conn = new SqlConnection(cs);
				SqlCommand cmd = new SqlCommand("pro_usersinfo", conn);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@userid", userdatamodel.userid);
				cmd.Parameters.AddWithValue("@firstname", userdatamodel.FirstName);
				cmd.Parameters.AddWithValue("@lastname", userdatamodel.LastName);
				cmd.Parameters.AddWithValue("@email", userdatamodel.email);
				//cmd.Parameters.AddWithValue("@birthday", birthday);
				//cmd.Parameters.AddWithValue("@gender", gender);
				cmd.Parameters.AddWithValue("@addr1", userdatamodel.addr1);
				cmd.Parameters.AddWithValue("@addr2", userdatamodel.addr2);
				cmd.Parameters.AddWithValue("@street", userdatamodel.street);
				cmd.Parameters.AddWithValue("@city", userdatamodel.city);
				cmd.Parameters.AddWithValue("@state", userdatamodel.state);
				cmd.Parameters.AddWithValue("@zipcode", userdatamodel.zipcode);
				cmd.Parameters.AddWithValue("@mobilenumber", userdatamodel.mobilenumber);
				//cmd.Parameters.AddWithValue("@password", password);
				conn.Open();
				object i = cmd.ExecuteNonQuery();
				conn.Close();
				return true;
			}
			catch(Exception ex)
			{
				return false;
			}
		}
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

		public UserInfoDataModel.UserInfoDataModel GetUserProfileDetails(string userid, string password)
		{
			UserInfoDataModel.UserInfoDataModel dataModel = new UserInfoDataModel.UserInfoDataModel();
			try
			{
				string cs = @"server=Sweetu\SQLEXPRESS;database=mynewproject;Trusted_Connection=True;";
				SqlConnection conn = new SqlConnection(cs);
				SqlCommand cmd = new SqlCommand("select userid,firstname,lastname,email,addr1,addr2,street,city,state,zipcode,mobilenumber from usersinfo where userid=@userid and password=@password", conn);
				cmd.Parameters.AddWithValue("@userid", userid);
				cmd.Parameters.AddWithValue("@password", password);
				conn.Open();
				cmd.ExecuteNonQuery();
				SqlDataReader dr = cmd.ExecuteReader();
				while (dr.Read())
				{
					dataModel.userid = (dr["userid"].ToString());
					dataModel.FirstName = (dr["firstname"].ToString());
					dataModel.LastName = (dr["lastname"].ToString());
					dataModel.email = (dr["email"].ToString());
					//dropdownmonth.Text = (dr["userid"].ToString());
					//dropdownday.Text = (dr["userid"].ToString());
					//dropdownyear.Text = (dr["userid"].ToString());
					//dataModel.SelectedItem.Text = (dr["gender"].ToString());
					dataModel.addr1 = (dr["addr1"].ToString());
					dataModel.addr2 = (dr["addr2"].ToString());
					dataModel.street = (dr["street"].ToString());
					dataModel.city = (dr["city"].ToString());
					dataModel.state = (dr["state"].ToString());
					dataModel.zipcode = (dr["zipcode"].ToString());
					dataModel.mobilenumber = (dr["mobilenumber"].ToString());
				}
				conn.Close();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}

			return dataModel;
		}
	}
		}

