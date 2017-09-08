using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
	public class ItemAssortmentRelationDTO
	{
		public int id { get; set; }

		public string itmassmst_ad { get; set; }

		public string rel_ad { get; set; }

		public string mod_ad { get; set; }

		public string itmassind_ad { get; set; }

		public int? l_trigger { get; set; }
	}
}
