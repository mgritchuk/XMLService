using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
	public class RelDTO
	{
		
		public RelDTO(string ad, string name1, string name2, string address1, string address2, string pcode, string city, string tel, string fax, string gsm, string itmass_ad, string itmprc_ad, string website, string email, int? relstatus_id, string finpaymentmethod_ad)
		{
			this.ad = ad;
			this.name1 = name1;
			this.name2 = name2;
			this.address1 = address1;
			this.address2 = address2;
			this.pcode = pcode;
			this.city = city;
			this.tel = tel;
			this.fax = fax;
			this.gsm = gsm;
			this.itmass_ad = itmass_ad;
			this.itmprc_ad = itmprc_ad;
			this.website = website;
			this.email = email;
			this.relstatus_id = relstatus_id;
			this.finpaymentmethod_ad = finpaymentmethod_ad;
		}

		public string ad { get; set; }

		public string name1 { get; set; }

		public string name2 { get; set; }

		public string address1 { get; set; }

		public string address2 { get; set; }

		public string pcode { get; set; }

		public string city { get; set; }

		public string tel { get; set; }

		public string fax { get; set; }

		public string gsm { get; set; }

		public string itmass_ad { get; set; }

		public string itmprc_ad { get; set; }

		public string website { get; set; }

		public string email { get; set; }

		public int? relstatus_id { get; set; }

		public string finpaymentmethod_ad { get; set; }

	}
}
