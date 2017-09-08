namespace Models.DTO
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Data.Entity.Spatial;

	public class SettingDTO
	{
		public int id { get; set; }

		public string syssection { get; set; }

		public string modmst_ad { get; set; }

		public string rel_ad { get; set; }

		public int? relusr_id { get; set; }

		public string sysfield { get; set; }

		public string sysvalue { get; set; }

	}
}
