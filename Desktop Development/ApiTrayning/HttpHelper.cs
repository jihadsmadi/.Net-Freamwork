using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace ApiTrayning
{
	public class HttpHelper
	{


		public string ConvertToJson(string Url)
		{
			HttpWebRequest request = HttpWebRequest.CreateHttp(Url);
			var response = request.GetResponse();
			StreamReader reader = new StreamReader(response.GetResponseStream());
			return  reader.ReadToEnd();

		}

	}
}
