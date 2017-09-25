﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
	public class ConfigModel
	{
		//FTPPath
		public string FTPhost { get; set; }

		//Credentials
		public string UserName { get; set; }

		public string Password { get; set; }

		//IngoingXML
		public string path { get; set; }
	}
}