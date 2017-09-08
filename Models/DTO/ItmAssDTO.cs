using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
	public class ItmAssDTO
	{
		public ItmAssDTO()
		{ }

		public ItmAssDTO(decimal? avg_wgt_col, string groups, string unit, string brand, string description)
		{
			this.avg_wgt_col = avg_wgt_col;
			this.groups = groups;
			this.unit = unit;
			this.brand = brand;
			this.description = description;
		}
		public int id { get; set; }

		public string itmassmst_ad { get; set; }

		public string itm_ad { get; set; }

		public string rel_ad { get; set; }

		public string seqnr { get; set; }

		public decimal? qty { get; set; }

		public decimal? avg_wgt_col { get; set; }

		public string groups { get; set; }

		public string unit{ get; set; }

		public string brand { get; set; }

		public string description { get; set; }

		public int? l_trigger { get; set; }
	}
}
