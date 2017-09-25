using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
	public class ImportInvoice
	{
		public ImportInvoice() { }

		public string Action { get; set; }
		public string Validation { get; set; }
		public string Displaycode { get; set; }
		public string SolidisPK { get; set; }
		public DateTime InvoiceDate { get; set; }
		public string SolidisCustomerPK { get; set; }
		public List<ImportInvoiceLine> InvoiceLines { get; set; }
		public string fileName { get; set; }
	}

	public class ImportInvoiceLine
	{
		public ImportInvoiceLine() { }
		public string InvoiceSolidisPK { get; set; }
		public string SolidisItemPK { get; set; }
		public string SolidisProductPK { get; set; }
		public string ArticleCode { get; set; }
		public double QuantityToDo { get; set; }
		public double AlternativeQuantityToDo { get; set; }
		public string ScannedBarcode { get; set; }
		public string fileName { get; set; }
	}
}
