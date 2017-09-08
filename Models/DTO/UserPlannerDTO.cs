using AutoMapper;
using Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
	public class UserPlannerDTO
	{

		public UserPlannerDTO(les_planner planner, les_planstatus member_status)
		{
			Mapper.Map(planner, this);
			this.member_status = Mapper.Map<PlanStatusDTO>(member_status);
		}
		public int id { get; set; }

		public int? status_id { get; set; }

		public PlanStatusDTO member_status { get; set; }

		public DateTime date { get; set; }

		public LessonDTO lesson { get; set; }
	}
}
