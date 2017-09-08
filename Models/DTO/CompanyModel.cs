using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
	public class CompanyModel
	{
		public string ad;
		public string name;
		public string link;

		public CompanyModel(string ad, string name, string link)
		{
			this.ad = ad;
			this.name = name;
			this.link = link;
		}
	}
}
