using Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
	public class LogVehicleDTO
	{

		public LogVehicleDTO() { }

		public LogVehicleDTO(OrdMainDTO ordmain, RelDTO rel)
		{
			this.ordmain = ordmain;
			this.rel = rel;
		}

		public int id { get; set; }

		public string ord_ad { get; set; }

		public string vehicle_ad { get; set; }

		public int user_id { get; set; }

		public UserDTO relusr { get; set; }

		public RelDTO rel { get; set; }

		public double longitude { get; set; }

		public double latitude { get; set; }

		public string type { get; set; }

		public DateTime dt_created { get; set; }

		public DateTime? dt_modified { get; set; }

		public OrdMainDTO ordmain { get; set; }
	}
}
