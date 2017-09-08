using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
	public class OrderListDTO
	{
		public OrderListDTO()
		{

		}

		public OrderListDTO(int count)
		{
			this.count = count;
		}

		public string ad { get; set; }

		public string description { get; set; }

		public int l_show { get; set; }

		public int? count { get; set; }

		public int? l_trigger { get; set; }
	}
}
