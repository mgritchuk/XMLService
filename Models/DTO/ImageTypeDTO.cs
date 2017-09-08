using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
	public class ImageTypeDTO
	{
		public string ad { get; set; }
		public string description { get; set; }
		public int l_show { get; set; }
		public DateTime dt_created { get; set; }
		public DateTime? dt_modified { get; set; }

	}
}
