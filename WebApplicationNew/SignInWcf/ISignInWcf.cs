using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SignInWcf
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISignIn" in both code and config file together.
	[ServiceContract]
	public interface ISignInWcf
	{
		[OperationContract]
		bool SignIn(string userid,string password);

		[OperationContract]
		void SignUp(string firstname, string email);
	}
}

