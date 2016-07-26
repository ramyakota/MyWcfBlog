using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SignUpWcf
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SignUpWcf" in both code and config file together.
	public class SignUpWcf : ISignUpWcf
	{
		public bool SignUp(string userid, string firstname, string lastname, string email, string birthday, string gender,
			string addr1, string addr2, string street, string city, string state, string zip, string mobile, string password)
		{

			string dateTime = "01/08/2008 14:50:50.42";
			IFormatProvider culture = new System.Globalization.CultureInfo("fr-FR", true);
			DateTime dt2 = DateTime.Parse(dateTime, culture, System.Globalization.DateTimeStyles.AssumeLocal);
			Console.WriteLine(" Month: {0}, Day: {1},Year: {2}, Hour: {3}, Minute: {4}, Second: {5}, Millisecond: {6}",
							  dt2.Year, dt2.Month, dt2.Day, dt2.Hour, dt2.Minute, dt2.Second, dt2.Millisecond);
			birthday = Convert.ToString(dt2);
			//DateTime dt = new DateTime(Convert.ToInt32(dropdownmonth.Text), Convert.ToInt32(dropdownday.Text), Convert.ToInt32(dropdownyear.Text));
			//string cs = ConfigurationManager.ConnectionStrings["users"].ConnectionString;
			string cs = @"server=Sweetu\SQLEXPRESS;database=mynewproject;Trusted_Connection=True;";
				SqlConnection conn = new SqlConnection(cs);
				SqlCommand cmd = new SqlCommand("insert into usersinfo values(@userid,@firstname,@lastname,@email,@birthday,@gender,@addr1,@addr2,@street,@city,@state,@zipcode,@mobilenumber,@password)", conn);
				cmd.Parameters.AddWithValue("@userid", userid);
				cmd.Parameters.AddWithValue("@firstname", firstname);
				cmd.Parameters.AddWithValue("@lastname", lastname);
				cmd.Parameters.AddWithValue("@email", email);
				cmd.Parameters.AddWithValue("@birthday", birthday);
				cmd.Parameters.AddWithValue("@gender", gender);
				cmd.Parameters.AddWithValue("@addr1", addr1);
				cmd.Parameters.AddWithValue("@addr2", addr2);
				cmd.Parameters.AddWithValue("@street", street);
				cmd.Parameters.AddWithValue("@city", city);
				cmd.Parameters.AddWithValue("@state", state);
				cmd.Parameters.AddWithValue("@zipcode", zip);
				cmd.Parameters.AddWithValue("@mobilenumber", mobile);
				cmd.Parameters.AddWithValue("@password", password);
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

			
	}
		}

