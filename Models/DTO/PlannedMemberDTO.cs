using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
	public class PlannedMemberDTO
	{
		public int id { get; set; }

		public string rel_ad { get; set; }

		public int? planner_id { get; set; }

		public int? relusr_id { get; set; }

		public int status_id { get; set; }

		public string notes { get; set; }

		public int? l_show { get; set; }

		public int l_new { get; set; }

		public List<DateTime> dates { get; set; } = new List<DateTime>();

		public LesUserDTO relusr { get; set; }

		public List<AbsenceDTO> absences { get; set; }
	}
}
