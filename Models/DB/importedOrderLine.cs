using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DB
{
	[Table("importedOrderLine")]
	public class importedOrderLine
	{
		[Key]
		[StringLength(50)]
		public string SolidisItemPK { get; set; }

		[Required]
		[StringLength(50)]
		public string orderSolidisPK { get; set; }

		[StringLength(50)]
		public string ArticleCode { get; set; }
		public double QuantityToDo { get; set; }
		public double AlternativeQuantityToDo { get; set; }

		[StringLength(100)]
		public string Notes { get; set; }
		[ForeignKey("orderSolidisPK")]
		public virtual importedOrder importedOrder { get; set; }

	}
}
