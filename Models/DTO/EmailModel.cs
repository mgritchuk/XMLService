using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.DB;

namespace Models.DTO
{
	public class EmailModel
	{
	
		public string email { get; set; }
		public string subject { get; set; }
		public string body { get; set; }

		public List<string> bccAddress { get; set; }

		public List<string> ccAddress { get; set; }

	}


	public class RichEmailModel
	{
		public string to { get; set; }
		public string from { get; set; }
		public string body { get; set; }
		public string header { get; set; }

		public List<string> base64Attachments { get; set; }
		public List<string> bcc { get; set; }
		public List<string> cc { get; set; }


	}
}
