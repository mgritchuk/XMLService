using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DB
{
	[Table("importedInvoiceLine")]
	public class importedInvoiceLine
	{
	
		[Key]
		[Column(Order = 1)]
		[StringLength(50)]
		public string SolidisItemPK { get; set; }

		[Key]
		[Column(Order = 2)]
		[StringLength(50)]
		public string SolidisProductPK { get; set; }

		[Required]
		[StringLength(50)]
		public string InvoiceSolidisPK { get; set; }

		[StringLength(50)]
		public string ArticleCode { get; set; }

		public double QuantityToDo { get; set; }

		public double AlternativeQuantityToDo { get; set; }

		[StringLength(100)]
		public string ScannedBarcode { get; set; }

		[ForeignKey("InvoiceSolidisPK")]
		public virtual importedInvoice importedInvoice { get; set; }
	}
}
