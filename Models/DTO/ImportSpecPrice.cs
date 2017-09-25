using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
	public class ImportSpecPrice
	{
		public string SolidisPK { get; set; }
		public string Name { get; set; }
		public string Action { get; set; }
		public string Validation { get; set; }

		public List<ImportSpecPriceItem> PriceItems { get; set; }

		public string fileName { get; set; }
	}

	public class ImportSpecPriceItem
	{
		public string Displaycode { get; set; }
		public string Description { get; set; }
		public string SolidisPK { get; set; }
		public string SpecPriceSolidisPK { get; set; }
		public double Price { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public string Type { get; set; }
		public string fileName { get; set; }
	}
}
