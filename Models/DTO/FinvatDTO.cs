using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
	public class FinvatDTO
	{

		public string ad { get; set; }

		public string description { get; set; }

		public decimal finvat_perc { get; set; }

		public int prc_ind { get; set; }

		public int? l_show { get; set; }

		public DateTime dt_created { get; set; }

		public DateTime? dt_modified { get; set; }

		public int syshumres_id { get; set; }

		public int systerminal_id { get; set; }

		public int syscompany_id { get; set; }
	}
}
