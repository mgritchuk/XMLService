using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
	public class LogOrdLineDTO
	{
		public long LogId { get; set; }

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

		public DateTime dt_created { get; set; }

		public DateTime? dt_modified { get; set; }

		public int syshumres_id { get; set; }

		public int systerminal_id { get; set; }

		public int syscompany_id { get; set; }

		public int? ordlinesflawstatus_id { get; set; }

		public int? ordlinesrefusedstatus_id { get; set; }

		public int? l_processed { get; set; }
	}
}
