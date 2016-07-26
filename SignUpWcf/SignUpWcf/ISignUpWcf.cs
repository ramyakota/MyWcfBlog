using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SignUpWcf
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISignUpWcf" in both code and config file together.
	[ServiceContract]
	public interface ISignUpWcf
	{
		[OperationContract]
		 bool SignUp(string userid, string firstname, string lastname, string email, string birthday, string gender,
			string addr1, string addr2, string street, string city, string state, string zip, string mobile, string password);
	}
}
