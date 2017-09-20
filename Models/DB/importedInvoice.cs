using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DB
{
	[Table("importedInvoice")]
	public class importedInvoice
	{
		[Key]
		[StringLength(50)]
		public string SolidisPK { get; set; }

		[StringLength(50)]
		public string Action { get; set; }

		[StringLength(50)]
		public string Validation { get; set; }

		[StringLength(50)]
		public string Displaycode { get; set; }
		
		public DateTime InvoiceDate { get; set; }

		[StringLength(50)]
		public string SolidisCustomerPK { get; set; }

		public virtual List<importedInvoiceLine> InvoiceLines { get; set; }
	}
}
