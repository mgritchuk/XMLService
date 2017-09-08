using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
	public class LessonTypeDTO
	{
		public int id { get; set; }

		public string rel_ad { get; set; }

		public string description { get; set; }

		public string notes { get; set; }

		public int condition { get; set; }

		public int strength { get; set; }

		public int relaxation { get; set; }

		public int? status_id { get; set; }

		public int l_show { get; set; }
	}
}
