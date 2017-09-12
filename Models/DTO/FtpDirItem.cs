using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
	public class FtpDirItem
	{
		public FtpDirItem() { }
		public FtpDirItem(string name)
		{
			Name = name;
			//DateCreated = date;
		}

		public string Name { get; set; }
		//public DateTime DateCreated { get; set; }
	}
}
