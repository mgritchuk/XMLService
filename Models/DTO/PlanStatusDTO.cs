using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
	public class PlanStatusDTO
	{
		public int id { get; set; }

		public string rel_ad { get; set; }

		public string type { get; set; }

		public string description { get; set; }

		public int? l_show { get; set; }
	}
}
