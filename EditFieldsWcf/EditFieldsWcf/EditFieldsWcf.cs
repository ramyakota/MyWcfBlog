using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace EditFieldsWcf
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EditFieldsWcf" in both code and config file together.
	public class EditFieldsWcf : IEditFieldsWcf
	{
		public bool Edit(string userid, string firstname, string lastname, string email, 
			string addr1, string addr2, string street, string city, string state, string zip, string mobile)
		{
			 string cs = @"server=Sweetu\SQLEXPRESS;database=mynewproject;Trusted_Connection=True;";
			SqlConnection conn = new SqlConnection(cs);
			SqlCommand cmd = new SqlCommand("pro_usersinfo", conn);
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.AddWithValue("@userid", userid);
			cmd.Parameters.AddWithValue("@firstname", firstname);
			cmd.Parameters.AddWithValue("@lastname", lastname);
			cmd.Parameters.AddWithValue("@email", email);
			//cmd.Parameters.AddWithValue("@birthday", birthday);
			//cmd.Parameters.AddWithValue("@gender", gender);
			cmd.Parameters.AddWithValue("@addr1", addr1);
			cmd.Parameters.AddWithValue("@addr2", addr2);
			cmd.Parameters.AddWithValue("@street", street);
			cmd.Parameters.AddWithValue("@city", city);
			cmd.Parameters.AddWithValue("@state", state);
			cmd.Parameters.AddWithValue("@zipcode", zip);
			cmd.Parameters.AddWithValue("@mobilenumber", mobile);
			//cmd.Parameters.AddWithValue("@password", password);
			conn.Open();
			object i =cmd.ExecuteNonQuery();
			conn.Close();
			if (Convert.ToInt16(i) > 0)
			{
				return true;
				
			}
			else
			{
				return false;
			}
		}
	}
}
