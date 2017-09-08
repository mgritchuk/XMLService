using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
	public class RelationContactsDTO
	{

		public int id { get; set; }

		public string rel_ad { get; set; }

		public string fullname { get; set; }
		public string relsalutation_ad { get; set; }

		public string foreletters { get; set; }

		public string firstname { get; set; }

		public string lastname { get; set; }

		public string searchname { get; set; }

		public string tel { get; set; }

		public int l_show { get; set; }

		public int? l_trigger { get; set; }

		public DateTime dt_created { get; set; }

		public DateTime? dt_modified { get; set; }
	}
}
