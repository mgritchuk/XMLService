using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
	public class OrderFilter
	{
		
		public string rel_ad_start { get; set; }

		public string rel_ad_stop { get; set; }

		[Required]
		public string mod_ad { get; set; }

		public int status_start { get; set; }

		public int? status_stop{ get; set; }

		public string vehicle_ad { get; set; }

		public DateTime? deliverydate_start { get; set; }

		public DateTime? deliverydate_stop { get; set; }

		public int? ordertype_start { get; set; }

		public int? ordertype_stop { get; set; }

		public int? user_id { get; set; }
	}
}
