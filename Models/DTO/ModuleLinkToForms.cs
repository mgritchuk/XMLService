using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
	public class ModuleLinkToForms
	{
		public ModuleLinkToForms(string mod_ad, string[] frmAdList)
		{
			this.mod_ad = mod_ad;
			this.frmAdList = frmAdList;

		}

		public string mod_ad { get; set; }

		public string[] frmAdList { get; set; }

	}
}
