using AutoMapper;
using Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
	public class PlannerDTO
	{
		public PlannerDTO()
		{

		}

		public PlannerDTO(les_planner planner, int member_count)
		{
			Mapper.Map(planner, this);
			this.member_count = member_count;
		}
		public int id { get; set; }

		public string rel_ad { get; set; }

		public int? status_id { get; set; }

		public int? l_show { get; set; }

		public DateTime date { get; set; }

		public int member_count { get; set; }

		public int? l_processed { get; set; }

		public LessonDTO lesson { get; set; }
	}
}
