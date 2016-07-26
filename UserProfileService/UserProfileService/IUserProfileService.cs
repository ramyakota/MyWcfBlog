using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using UserInfoDataModel;

namespace UserProfileService
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IUserProfileService" in both code and config file together.
	[ServiceContract]
	public interface IUserProfileService
	{
		[OperationContract]
		bool SignIn(string userid, string password);

		[OperationContract]
		UserInfoDataModel.UserInfoDataModel GetUserProfileDetails(string userid);

		[OperationContract]
		 bool SignUp(string userid, string firstname, string lastname, string email, string birthday, string gender,
			string addr1, string addr2, string street, string city, string state, string zip, string mobile, string password);

		[OperationContract]
		bool Edit(string userid, string firstname, string lastname, string email,
			string addr1, string addr2, string street, string city, string state, string zip, string mobile);
	}
}
