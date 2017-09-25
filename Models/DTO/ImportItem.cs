using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
	public class ImportItem
	{

		public ImportItem() { }
		public ImportItem(string displayCode, string solidis, string desc, string measureUnit, string tradeMeasureUnit)
		{
			DisplayCode = displayCode;
			SolidisPK = solidis;
			Description = desc;
			DefaultTradeUnitOfMeasure = tradeMeasureUnit;
			DefaultUnitOfMeasure = measureUnit;
		}

		public string Action { get; set; }

		public string Validation { get; set; }
		public string DisplayCode { get; set; }
		public string SolidisPK { get; set; }
		public string Description { get; set; }
		public string DefaultUnitOfMeasure { get; set; }
		public string DefaultTradeUnitOfMeasure { get; set; }
		public string fileName { get; set; }

	}
}
