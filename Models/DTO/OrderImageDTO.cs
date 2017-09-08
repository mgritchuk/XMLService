using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
	public class OrderImageDTO
	{
		public int id { get; set; }

		public string ord_ad { get; set; }

		public string filename { get; set; }

		public string description { get; set; }

		public int? l_show { get; set; }

		public int? l_signature { get; set; }

		public string contents { get; set; }
	}
}
