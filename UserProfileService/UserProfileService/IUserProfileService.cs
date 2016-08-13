using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using UserInfoDataModel;
using UserProfileDataModel;

namespace UserProfileService
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IUserProfileService" in both code and config file together.
	[ServiceContract]
	public interface IUserProfileService
	{
		[OperationContract]
		bool SignIn(string userid, string password);

		[OperationContract]
		UserInfoDataModel.UserInfoDataModel GetUserProfileDetails(string userid, string password);

		[OperationContract]
		 bool SignUp(UserProfileDataModel.UserProfileDataModel userProfileDataModel);

		[OperationContract]
		bool Edit(UserInfoDataModel.UserInfoDataModel userdatamodel);
	}
}
