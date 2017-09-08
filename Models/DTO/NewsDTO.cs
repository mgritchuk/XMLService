using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
	public class NewsDTO
	{
		public NewsDTO(string title, string body, DateTime pubdate, string cover)
		{
			this.title = title;
			this.body = body;
			this.pubdate = pubdate;
			this.cover = cover;
		}

		public string title { get; set; }

		public string body { get; set; }

		public DateTime pubdate { get; set; }

		public string cover { get; set; }
	}
}
