using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
	public class PromoItemDTO
	{
		public int id { get; set; }

		public string itm_ad { get; set; }

		public decimal qty { get; set; }

		public decimal prc_pce { get; set; }
		public string promo_code { get; set; }

		public DateTime dt_start { get; set; }

		public DateTime dt_end { get; set; }
	}
}
