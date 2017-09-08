using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
	public class TransportVehicleDTO
	{
		public string ad { get; set; }

		public string qr { get; set; }

		public string licenseplate { get; set; }

		public int last_kmcount { get; set; }

		public string description { get; set; }

		public int? l_show { get; set; }
	}
}
