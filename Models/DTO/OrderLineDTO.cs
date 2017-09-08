using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Models.DTO
{
	public class OrderLineDTO
	{
		public OrderLineDTO(string groups, string description, decimal? avg, string unit, decimal? price, bool isPromo, string brand)
		{
			this.groups = groups;
			this.description = description;
			itmunit_ad = unit;
			avg_wgt_col = avg;
			prc_pce = price;
			l_promo = isPromo ? 1 : 0;
			this.brand = brand;
		}

		public OrderLineDTO()
		{
		}

		public int id { get; set; }

		public string rel_ad { get; set; }

		public int? pasline_id { get; set; }

		public string ord_ad { get; set; }

		public string itm_ad { get; set; }

		public string itmgrp_ad { get; set; }

		public decimal? qty_ordered { get; set; }

		public decimal? qty_delivered_tour { get; set; }

		public decimal? qty_delivered { get; set; }

		public decimal? prc_pce { get; set; }

		public string finvat_ad { get; set; }

		public string remarks { get; set; }

		public string prdnotes { get; set; }

		public string seqno { get; set; }

		public int? l_promo { get; set; }

		public int? ordlinesflawstatus_id { get; set; }

		public int? ordlinesrefusedstatus_id { get; set; }

		public string groups { get; set; }

		public decimal? avg_wgt_col { get; set; }

		public string itmunit_ad { get; set; }

		public string description { get; set; }

		public string brand { get; set; }

		public int? l_trigger { get; set; }

	}
}
