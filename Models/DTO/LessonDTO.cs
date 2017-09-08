using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
	public class LessonDTO
	{
		public int id { get; set; }

		public string rel_ad { get; set; }

		public int? relusr_id { get; set; }

		public string description { get; set; }

		public int type_id { get; set; }

		public string notes { get; set; }

		public int max_registred { get; set; }

		public DateTime start_date { get; set; }

		public DateTime end_date { get; set; }

		public TimeSpan? time_from { get; set; }

		public TimeSpan? time_to { get; set; }

		public int interval_id { get; set; }

		public string day { get; set; }

		public int? status_id { get; set; }

		public int reg_req { get; set; }

		public int l_show { get; set; }
	}
}
