using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
	public class LogOrdmainDTO
	{
		public long LogId { get; set; }

		public string ord_ad { get; set; }

		
		public string rel_ad { get; set; }

		public string mod_ad { get; set; }

		public string pasord_ad { get; set; }

		public int ordtype_id { get; set; }

		public int? relusr_id { get; set; }

		public int? ordstatus_id { get; set; }

		public DateTime? dt_delivered { get; set; }

		public DateTime? dt_ordered { get; set; }

		public string _ref { get; set; }


		public string invoice_ad { get; set; }

		public DateTime? dt_invoice { get; set; }

		
		public string delivery_ad { get; set; }

		public DateTime? dt_delivery { get; set; }

		public string notes { get; set; }

		public DateTime dt_created { get; set; }

		public DateTime? dt_modified { get; set; }

		public int? syshumres_id { get; set; }

		public int? systerminal_id { get; set; }

		public int? syscompany_id { get; set; }

		public string tsptour_ad { get; set; }

	
		public string coord_x { get; set; }


		public string coord_y { get; set; }


		public string tspvehicle_ad { get; set; }

		public string notes_delivered { get; set; }

		public string lastname_delivered { get; set; }

		public string notes_complaint { get; set; }

		public string notes_wish { get; set; }

		public string notes_quality { get; set; }

		public string notes_temperature { get; set; }

		public DateTime? dt_start_tsptour { get; set; }

		public DateTime? dt_stop_tsptour { get; set; }


		public string fincur_ad { get; set; }

		public int? l_processed { get; set; }
	}
}
