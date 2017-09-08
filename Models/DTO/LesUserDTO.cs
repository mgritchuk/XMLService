using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
	public class LesUserDTO
	{
		public LesUserDTO()
		{

		}

		public LesUserDTO(string role_ad )
		{
			this.role_ad = role_ad;
		}

		public int id { get; set; }

		public string rel_ad { get; set; }

		public string usr_name { get; set; }

		public string email { get; set; }

		public string fullname { get; set; }

		public string usr_pwd { get; set; }

		public string phonenum { get; set; }

		public string phone_home { get; set; }

		public DateTime dt_birth { get; set; }

		public string profilephoto { get; set; }

		public int status_id { get; set; }

		public string description { get; set; }

		public string role_ad { get; set; }
	}
}
