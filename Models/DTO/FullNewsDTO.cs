using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
	public class FullNewsDTO
	{
		
		public FullNewsDTO(string rel_ad, string relnewsgrpmst_ad, string frmmst_ad, DateTime dt_start, DateTime dt_stop, string headertext, string bodytext, string relnewsimage)
		{
			this.rel_ad = rel_ad;
			this.relnewsgrpmst_ad = relnewsgrpmst_ad;
			this.frmmst_ad = frmmst_ad;
			this.dt_start = dt_start;
			this.dt_stop = dt_stop;
			this.headertext = headertext;
			this.bodytext = bodytext;
			this.relnewsimage = relnewsimage;
		}

		public int id { get; set; }

		public string rel_ad { get; set; }

		public string relnewsgrpmst_ad { get; set; }

		public string frmmst_ad { get; set; }

		public DateTime dt_start { get; set; }

		public DateTime dt_stop { get; set; }

		public string headertext { get; set; }

		public string bodytext { get; set; }

		public string relnewsimage { get; set; }
	}
}
