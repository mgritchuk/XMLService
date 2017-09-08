using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
	public class UserDTO
	{
		public int id { get; set; }

		public string rel_ad { get; set; }

		public string usr_name { get; set; }

		public string email { get; set; }

		public string fullname { get; set; }

		public int? l_showprc { get; set; }

		public int? l_showamountexcl { get; set; }

		public string securitycode { get; set; }

		public string lang { get; set; }

		public DateTime dt_created { get; set; }

		public string usr_pwd { get; set; }

		public int? relusrtype_id { get; set; }

		public string phonenum { get; set; }

		public short l_enabled { get; set; }
		public int? l_trigger { get; set; }

	}
}
