using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
	public class ItemImageDTO
	{
		public ItemImageDTO() { }

		public ItemImageDTO(string imgtype_ad, string itm_ad, string imgpath)
		{
			this.imgpath = imgpath;
			this.imgtype_ad = imgtype_ad;
			this.itm_ad = itm_ad;
		}

		public int id { get; set; }
		
		public string imgtype_ad { get; set; }

		public string itm_ad { get; set; }
		
		public string imgpath { get; set; }

		public DateTime dt_created { get; set; }

		public DateTime? dt_modified { get; set; }
	}

}
