using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
	public class ItemPriceDTO
	{
		public int id { get; set; }

		public string itm_ad { get; set; }

		public decimal? qty { get; set; }

		public string unit_ad { get; set; }

		public decimal? prc_pce { get; set; }

	}
}
