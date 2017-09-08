using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
	public class OrderLineRefusedDTO
	{
		public int id { get; set; }
		public string description { get; set; }
		public bool l_show { get; set; }
	}
}
