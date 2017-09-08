using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
	public class RoleDTO
	{
		public int id { get; set; }

		public string roletype { get; set; }

		public string groupname { get; set; }

		public string name { get; set; }

		public string mod_ad { get; set; }

		public short l_read { get; set; }

		public short l_write { get; set; }
	}
}
