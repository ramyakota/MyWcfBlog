using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace SignInServiceHost
{
	class Program
	{
		static void Main(string[] args)
		{
			using (ServiceHost host = new ServiceHost(typeof(SignInWcf.SignInWcf)))
			{
				host.Open();
				Console.WriteLine("Host Started @" + DateTime.Now.ToString());
				Console.ReadLine();
			}
		}
	}
}
