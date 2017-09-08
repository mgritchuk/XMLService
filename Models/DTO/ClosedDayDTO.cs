using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
	public class ClosedDayDTO
	{
		public int id { get; set; }

		public string rel_ad { get; set; }

		public string description { get; set; }

		public DateTime date { get; set; }

		public int l_show { get; set; }
	}
}
