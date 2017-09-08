using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
	public class SelectListDTO
	{
		public SelectListDTO()
		{
		}

		public SelectListDTO(string ad, string description)
		{
			this.ad = ad;
			this.description = description;

		}

		public string ad { get; set; }

		public string description { get; set; }

		public int? l_show { get; set; }

	}
}
