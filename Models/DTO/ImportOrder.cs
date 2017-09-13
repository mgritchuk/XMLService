using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
	public class ImportOrder
	{
		public string Action { get; set; }
		public string Validation { get; set; }
		public string Displaycode { get; set; }
		public string SolidisPK { get; set; }
		public List<ImportOrderLine> OrderLinesList { get; set; }
	}

	public class ImportOrderLine
	{
		public string SolidisItemPK { get; set; }
		public string ArticleCode { get; set; }
		public double QuantityToDo { get; set; }
		public double AlternativeQuantityToDo { get; set; }
		public string Notes { get; set; }
	}
}
