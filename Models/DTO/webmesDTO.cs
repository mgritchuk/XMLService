using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
	public class webmesDTO
	{
		public int id { get; set; }

		public string rel_ad { get; set; }

		public int l_show { get; set; }

		public string subject { get; set; }

		public string content_update { get; set; }

		public DateTime? dt_expired { get; set; }

	}
}
