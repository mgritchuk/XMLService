using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
	public class ItemDTO
	{
		public ItemDTO()
		{

		}

		public ItemDTO(decimal? prc, string groups)
		{
			this.salprc = prc;
			this.groups = groups;
		}

		public string ad { get; set; }

		public string description { get; set; }

		public string itmunit_ad { get; set; }

		public string itmclc_ad { get; set; }

		public string itmpreparation { get; set; }

		public string itmgrp_ad { get; set; }

		public decimal? salprc { get; set; }

		public string finvat_ad { get; set; }

		public string order_unit { get; set; }

		public string delivery_unit { get; set; }

		public string desc_contents { get; set; }

		public string brand { get; set; }

		public string storage_temperature { get; set; }

		public string ingredients { get; set; }
		
		//public string allergens { get; set; }

		public string nutrition_value { get; set; }

		public string prdnotes { get; set; }

		public decimal? ikb_kcal100 { get; set; }

		public decimal? avg_wgt_col { get; set; }

		public int? itemsort { get; set; }

		public int? l_show { get; set; }

		public string groups { get; set; }

		public string imagePath { get; set; }
	}
}
