using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Simple.Web;

namespace WebApplication1
{
	[UriTemplate("/")]
	public class Home : IGet
	{
		public Status Get()
		{
			return 200;
		}
	}
}