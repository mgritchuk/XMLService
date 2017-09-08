using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
	public class LogEmailDTO
	{

		public LogEmailDTO() { }

		public LogEmailDTO(string header, string body, string addressTo)
		{
			this.header = header;
			this.body = body;
			this.addressTo = addressTo;
		}

		public int logId { get; set; }


		public string header { get; set; }


		public string body { get; set; }

		public string addressTo { get; set; }

		public DateTime dt_created { get; set; }

		public int? l_processed { get; set; }
	}
}
