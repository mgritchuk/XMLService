using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
	public class AccessIpDTO
	{
		public int id { get; set; }

		public string rel_ad { get; set; }

		public string ip_address { get; set; }

		public string host { get; set; }

		public string name { get; set; }

		public int l_show { get; set; }
	}
}
