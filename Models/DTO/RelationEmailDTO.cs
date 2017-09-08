using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
	public class RelationEmailDTO
	{
		public int id { get; set; }
		public string rel_ad { get; set; }

		public int relcontact_id { get; set; }

		public string email { get; set; }

		public int l_show { get; set; }

		public DateTime dt_created { get; set; }

		public DateTime? dt_modified { get; set; }
	}
}
