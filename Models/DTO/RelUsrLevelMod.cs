using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
	class RelUsrLevelMod
	{
		public int id { get; set; }

		public string rel_ad { get; set; }

		public int relusrlevel_id { get; set; }

		public int? relusr_id { get; set; }

		public string mod_ad { get; set; }

		public int? l_show { get; set; }

		public DateTimeOffset? dt_created { get; set; }
	}
}
