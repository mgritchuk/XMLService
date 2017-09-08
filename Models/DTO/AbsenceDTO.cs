using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
	public class AbsenceDTO
	{
		public int id { get; set; }

		public string rel_ad { get; set; }

		public int? planner_id { get; set; }

		public int? planner_member_id { get; set; }

		public int is_absence { get; set; }

		public string notes { get; set; }

		public int? l_show { get; set; }
	}
}
